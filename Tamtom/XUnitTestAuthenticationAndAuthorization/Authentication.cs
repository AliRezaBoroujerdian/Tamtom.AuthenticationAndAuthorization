using System;
using Xunit;
//
using Tamtom.AuthenticationAndAuthorization.Authentication;
using Tamtom.AuthenticationAndAuthorization.Authentication.Models;
using Tamtom.Application;

namespace XUnitTestAuthenticationAndAuthorization
{
    public class AuthenticationAndAuthorization
    {
        public AuthenticationAndAuthorization()
        {
            //DataAccess.Initialize("185.120.222.4", "LMSCore", "LMSCoreDBUser", "$WR4TTySb10*^c1c");

            DataAccess.Initialize(".", "Tamtom", "sa", "1");
        }


        [Fact]
        public async void Login()
        {
            LoginModel loginModel = new LoginModel()
            {
                Username = "0015686434",
                Password = "123467",
                Platform = "web",
                OS = "WinNT",
                Model = "Mozila",
                Version = "38.2",
                IP = "1.1.1.1"
            };

            LoginResultModel loginResultModel = await new Authentication().Login(loginModel);

            Assert.Equal(1, loginResultModel.Result);
            Assert.NotNull(loginResultModel.UserToken);
            Assert.NotNull(loginResultModel.SessionID);
        }
    }
}
