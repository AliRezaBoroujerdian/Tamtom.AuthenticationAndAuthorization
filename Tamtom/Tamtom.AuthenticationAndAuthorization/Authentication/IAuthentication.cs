using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tamtom.AuthenticationAndAuthorization.Authentication.Models;

namespace Tamtom.AuthenticationAndAuthorization.Authentication
{
    public interface IAuthentication
    {
        Task<LoginResultModel> Login(LoginModel model);
    }
}
