using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Scorchy.Core.Models
{
    public class User
    {
        public String Name { get; set; }
        public string Password { get; set; }
        public NetworkCredential Credential { get; set; }
    }
}
