using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scorchy.Core.Models
{
    public class Parameter:BaseINPCClass
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public Guid RunbookId { get; set; }
        private string _val;
        public string Value { get { return _val; }
            set
            {
                if (_val == value) return;
                _val = value;
                OnPropertyChanged(GetPropertyName(() => Value));
            }
        }
        public string Direction { get; set; }
    }
}
