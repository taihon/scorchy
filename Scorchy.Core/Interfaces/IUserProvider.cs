using Scorchy.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Scorchy.Core.Interfaces
{
    public interface IUserProvider
    {
        User ValidateLoginAttempt(string UserName, string Password);
        User ValidateLoginAttempt(string UserName, SecureString Password, string DomainName);
        User ValidateLoginAttempt(string UserName, string Password, string DomainName);
        User GetCurrentUser();
        string GetCurrentDomain();
    }
}
