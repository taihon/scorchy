using Scorchy.Core.Models;
using System.Collections.Generic;

namespace Scorchy.Core.Interfaces
{
    public interface IEventProvider
    {
        IEnumerable<RunbookEvent> GetEvents();
        IEnumerable<RunbookEvent> GetEvents(int amount, int skip = 0);
    }
}
