using A01.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A01.Data
{
    public class AuthenticationService
    {
        public Task<bool> Authenticate(AuthModel model)
        {
            var authenticated = false;
            //TODO: determine if login is a success

            return Task.Run(() => 1 == 0);
        }
    }
}
