using A01.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;

namespace A01.Data
{
    public interface IAuthenticationService
    {
        public Task<bool> Authenticate(AzureDbContext db, AuthModel model);
    }
    public class AuthenticationService : IAuthenticationService
    {
        public async Task<bool> Authenticate(AzureDbContext db, AuthModel model)
        {
            //TODO: determine if login is a success

            using (db)
            {
                try
                {
                    var a = db.Accounts.FirstOrDefault();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return 1 == 0;
        }
    }
}
