using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorchy.Core.Models
{
    public class RunbookEvent
    {
        public Guid EventID { get; set; }
        public DateTime CreationTime { get; set; }
        public string Summary { get; set; }
        public Guid SourceId { get; set; }
        public string Description { get; set; }
    }
}
