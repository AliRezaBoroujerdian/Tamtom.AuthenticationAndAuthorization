using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tamtom.AuthenticationAndAuthorization.Authentication.Models;
using static Tamtom.Database.Dapper.Generic;

namespace Tamtom.AuthenticationAndAuthorization.Authentication
{
    public  class Authentication : IAuthentication
    {
        public async Task<LoginResultModel> Login(LoginModel model)
        {
            return await ExecuteStoredProcedureFirstOrDefaultAsync<LoginModel, LoginResultModel>("[Identity].APP_SP_LoginUser",  model);
        }
    }
}
