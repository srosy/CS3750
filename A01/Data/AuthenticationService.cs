using A01.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;


namespace A01.Data
{
    public interface IAuthenticationService
    {
        public Task<bool> Authenticate(AzureDbContext db, AuthModel model);
    }
    public class AuthenticationService : IAuthenticationService
    {
        public IConfiguration Configuration { get; }
        public AuthenticationService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task<bool> Authenticate(AzureDbContext db, AuthModel model)
        {
            //determine if login is a success
            try
            {
                var acct = db.Accounts.FirstOrDefault(a => a.Email.ToLower().Equals(model.UserName.ToLower()));
                if (acct == null) return false;

                var auth = db.Authentications.FirstOrDefault(a => a.AccountId == acct.AccountId);
                if (auth == null) return false;

                if (!model.Password.Equals(auth.Password)) return false; // case-sensitive

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}

