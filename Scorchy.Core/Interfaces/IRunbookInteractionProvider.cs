using Scorchy.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace Scorchy.Core.Interfaces
{
    public interface IRunbookInteractionProvider
    {
        IEnumerable<RunbookObject> GetRunbooks();
        IEnumerable<Parameter> GetRunbookParameters(Guid rbguid);
        bool ExecuteRunbook(Guid rbGuid, IEnumerable<Parameter> parameters);
        bool ExecuteRunbook(Guid rbGuid, DataTable parameters);
    }
}
