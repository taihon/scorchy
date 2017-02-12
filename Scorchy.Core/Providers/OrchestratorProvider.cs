using Scorchy.Core.Interfaces;
using Scorchy.Core.Models;
using Scorchy.Core.Orchestrator;
using System;
using System.Collections.Generic;
using System.Data.Services.Client;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace Scorchy.Core.Providers
{
    public class OrchestratorProvider : IEventProvider, IRunbookInteractionProvider, IJobProvider
    {
        private const int MAX_RECORD_TO_TAKE = 50;
        private OrchestratorContext _context;
        private NetworkCredential _creds;
        private List<Runbook> _runbooks;
        public OrchestratorProvider(NetworkCredential creds, string serviceUri)
        {
            Uri serviceRoot = new Uri(serviceUri);
            _context = new OrchestratorContext(serviceRoot);
            _context.Credentials = creds;
            _creds = creds;
            //_runbooks = _context.Runbooks.ToList();
            _context.MergeOption = MergeOption.OverwriteChanges;
            int i = 0;
            var rbs = _context.Runbooks.Skip(i * 50).Take(50);
            _runbooks = new List<Runbook>();
            while (rbs.Count()!=0)
            {
                _runbooks.AddRange(rbs.ToList());
                i++;
                rbs = _context.Runbooks.Skip(i * 50).Take(50);
            }
        }

        public IEnumerable<RunbookEvent> GetEvents()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RunbookEvent> GetEvents(int amount, int skip = 0)
        {
            return _context.Events
                .OrderByDescending(e => e.CreationTime)
                .Skip(skip)
                .Take(amount)
                .Select(
                    ev => new RunbookEvent()
                    {
                        CreationTime = ev.CreationTime,
                        Description = ev.Description,
                        EventID = ev.Id,
                        SourceId = ev.SourceId,
                        Summary = ev.Summary
                    });
        }

        public IEnumerable<RunbookObject> GetRunbooks()
        {
            //var rbs = _context.Runbooks.Expand("Parameters").ToList();
            var runbooks = _runbooks.Select(t=>new RunbookObject(){
                Name=t.Name,
                Path=t.Path,
                RunbookId=t.Id
            });
            return runbooks;

            throw new NotImplementedException();
        }


        public IEnumerable<Parameter> GetRunbookParameters(Guid rbId)
        {
            return _context
                .RunbookParameters
                .Where(par => par.RunbookId == rbId && par.Direction == "In")
                .Select(
                    rbpar => new Parameter()
                    {
                        Guid = rbpar.Id,
                        Name = rbpar.Name,
                        RunbookId = rbpar.RunbookId
                    });
        }

        public IEnumerable<RunbookJob> GetJobs(int amount, int page, bool resolveUsernames = false)
        {
            
            return transformOrchestratorJobToRunbookJobModel(_context
                .Jobs
                .OrderByDescending(t=>t.CreationTime)
                .Skip(amount * page)
                .Take(amount)
            );
        }
        private string resolveSid(string sid)
        {
                Regex re = new Regex(@"^S-\d-\d+-(\d+-){1,14}\d+$", RegexOptions.Compiled|RegexOptions.IgnoreCase);
                if(re.IsMatch(sid))
                    return new System.Security.Principal.SecurityIdentifier(sid).Translate(typeof(System.Security.Principal.NTAccount)).ToString();
                return sid;
        }
        private string sanitizeParametersString(string inp)
        {
            Regex re = new Regex(@"<Name>(?<ParamName>.+?)<\/Name>.+?<Value>(?<ParamValue>.+?)??<\/Value>",RegexOptions.Compiled|RegexOptions.IgnoreCase);
            if (!string.IsNullOrEmpty(inp))
            {
                if (re.IsMatch(inp))
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (Match m in re.Matches(inp))
                    {
                        sb.Append(m.Groups["ParamName"].Value);
                        sb.Append(':');
                        sb.Append(' ');
                        sb.Append(m.Groups["ParamValue"].Value);
                        sb.Append(Environment.NewLine);
                    }
                    sb.Remove(sb.Length - Environment.NewLine.Length, Environment.NewLine.Length);
                    return sb.ToString();
                }
            }
            return string.Empty;
        }


        public IEnumerable<RunbookJob> FindJobsByParameterValue(string searchText)
        {
            return transformOrchestratorJobToRunbookJobModel( 
                _context
                .Jobs
                .Expand("Runbook")
                .Where(t=>t.Parameters.Contains(searchText))
                .OrderByDescending(t=>t.CreationTime)
                .Take(MAX_RECORD_TO_TAKE)
                );
        }
        private IEnumerable<RunbookJob> transformOrchestratorJobToRunbookJobModel(IEnumerable<Job> input)
        {
            return input.Select(rbj =>
                    new RunbookJob()
                    {
                        CreatedBy = resolveSid(rbj.CreatedBy),
                        CreationTime = rbj.CreationTime,
                        JobId = rbj.Id,
                        ModifiedAt = rbj.LastModifiedTime,
                        Parameters = sanitizeParametersString(rbj.Parameters),
                        Runbook = resolveRunbookName(rbj.RunbookId),
                        Status = rbj.Status
                    });
        }
        private string resolveRunbookName(Guid id)
        {
            var rb = _runbooks.FirstOrDefault(f => f.Id == id);
            if (rb != null)
                return rb.Name;
            return "Runbook name not found";
        }

        public bool ExecuteRunbook(Guid rbGuid, IEnumerable<Parameter> parameters)
        {
            var rbParams = _context.RunbookParameters.Where(rbp => rbp.RunbookId == rbGuid && rbp.Direction == "In").ToList();
            if (rbParams != null && rbParams.Count() > 0)
            {
                if (!rbParams.OrderBy(t => t.Id).Select(t => t.Id).SequenceEqual(parameters.OrderBy(p=>p.Guid).Select(p=>p.Guid)))
                {
                    //some of parameters not found either in one or another collection
                    return false;
                }
                if (parameters.Any(p => p.Name.Contains('*') && string.IsNullOrWhiteSpace(p.Value)))
                {
                    //mandatory parameters are marked with '*'
                    return false;
                }
                string parametersXml = convertParametersToXmlString(parameters);
                try
                {
                    Job j = new Job();
                    j.RunbookId = rbGuid;
                    j.CreationTime = DateTime.Now;
                    j.LastModifiedTime = DateTime.Now;
                    j.Parameters = parametersXml;
                    _context.AddToJobs(j);
                    _context.SaveChanges();
                    return true;
                }
                catch (DataServiceQueryException ex)
                {
                    //some problem happened
                    return false;
                    throw;
                }
            }
            return false;
            //i'm not sure how we got there.
            throw new NotImplementedException();
        }

        private string convertParametersToXmlString(IEnumerable<Parameter> parameters)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<Data>");
            foreach (Parameter p in parameters)
            {
                sb.AppendFormat("<Parameter><Name>{0}</Name><ID>{1}</ID><Value>{2}</Value></Parameter>", p.Name, p.Guid.ToString("B"), p.Value);
            }
            sb.Append("</Data>");
            return sb.ToString();
        }


        public bool ExecuteRunbook(Guid rbGuid, System.Data.DataTable parameters)
        {
            throw new NotImplementedException();
        }
    }
}
