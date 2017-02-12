using Scorchy.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorchy.Core.Interfaces
{
    public interface IJobProvider
    {
        IEnumerable<RunbookJob> GetJobs(int amount, int page,bool resolveUser=false);
        IEnumerable<RunbookJob> FindJobsByParameterValue(string searchText);
    }
}
