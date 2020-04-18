using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tamtom.AuthenticationAndAuthorization.Authentication.Models;
using static Tamtom.Database.Dapper.Generic;

namespace Tamtom.AuthenticationAndAuthorization.Authentication
{
    public class Authentication : IAuthentication
    {
        public async Task<DirectRegisterResultModel> DirectRegister(DirectRegisterModel model)
        {
            return await ExecuteStoredProcedureFirstOrDefaultAsync<DirectRegisterModel, DirectRegisterResultModel>("[Identity].APP_SP_DirectRegister", model);
        }



    }
}
