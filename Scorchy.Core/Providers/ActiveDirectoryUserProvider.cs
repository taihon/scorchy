using Scorchy.Core.Models;
using Scorchy.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace Scorchy.Core.Providers
{
    public class ActiveDirectoryUserProvider : IUserProvider
    {
        public User ValidateLoginAttempt(string UserName, string Password)
        {
            throw new NotImplementedException();
        }

        public User ValidateLoginAttempt(string UserName, System.Security.SecureString Password, string DomainName)
        {
            bool isAuthenticated=false;
            var networkCredential = new NetworkCredential(UserName, Password, DomainName);
            try
            {
                using (var ldap = new LdapConnection(DomainName))
                {                    
                    ldap.SessionOptions.VerifyServerCertificate = new VerifyServerCertificateCallback((con, cer) => true);
                    ldap.SessionOptions.SecureSocketLayer = false;
                    ldap.SessionOptions.ProtocolVersion = 3;
                    ldap.AuthType = AuthType.Negotiate;
                    ldap.Bind(networkCredential);
                }

                // If the bind succeeds, we have a valid user/pass.
                isAuthenticated = true;
            }
            catch (LdapException ldapEx)
            {
                // Error Code 0x31 signifies invalid credentials, anything else will be caught outside.
                if (!ldapEx.ErrorCode.Equals(0x31))
                {
                    throw;
                }
            }
            Password.Dispose();
            if (isAuthenticated)
                return new User() { Name = UserName, Credential=networkCredential };
            return null;
        }

        public string GetCurrentDomain()
        {
            return Domain.GetCurrentDomain().Name;
        }


        public User ValidateLoginAttempt(string UserName, string Password, string DomainName)
        {
            bool isAuthenticated = false;
            var networkCredential = new NetworkCredential(UserName, Password, DomainName);
            try
            {
                using (var ldap = new LdapConnection(DomainName))
                {
                    ldap.SessionOptions.VerifyServerCertificate = new VerifyServerCertificateCallback((con, cer) => true);
                    ldap.SessionOptions.SecureSocketLayer = false;
                    ldap.SessionOptions.ProtocolVersion = 3;
                    ldap.AuthType = AuthType.Negotiate;
                    ldap.Bind(networkCredential);
                }

                // If the bind succeeds, we have a valid user/pass.
                isAuthenticated = true;
            }
            catch (LdapException ldapEx)
            {
                // Error Code 0x31 signifies invalid credentials, anything else will be caught outside.
                if (!ldapEx.ErrorCode.Equals(0x31))
                {
                    throw;
                }
            }
            Password = null;
            if (isAuthenticated)
                return new User() { Name = UserName, Credential = networkCredential };
            return null;
        }


        public User GetCurrentUser()
        {
            NetworkCredential creds = CredentialCache.DefaultNetworkCredentials;
            return new User() { Name = WindowsIdentity.GetCurrent().Name, Credential = creds };
        }
    }
}
