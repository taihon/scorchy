using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorchy.Core.Models
{
    public class RunbookJob:BaseINPCClass
    {
        [DisplayName("Started by")]
        public string CreatedBy { get; set; }
        [DisplayName("Date of start")]
        public DateTime CreationTime { get; set; }
        [DisplayName("Job identifier")]
        public Guid JobId { get; set; }
        [DisplayName("Input parameters")]
        public string Parameters { get; set; }
        [DisplayName("Date of status change")]
        public DateTime ModifiedAt { get; set; }
        [DisplayName("Runbook")]
        public string Runbook { get; set; }
        [DisplayName("Current status")]
        public string Status { get; set; }
    }
}
