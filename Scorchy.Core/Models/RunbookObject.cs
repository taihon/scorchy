using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Scorchy.Core.Models
{
    public class RunbookObject:BaseINPCClass
    {
        public Guid RunbookId { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public IEnumerable<Parameter> Parameters { get; set; }
        
    }
}
