using NUnit.Framework;
using Travels_Test.PageObjects;
using Travels_Test.Framework;
using System.Threading;

namespace Travels_Test.Tests
{
    [TestFixture]
    
    public class LoginLogout_Test : BaseTest
    {
        [Test] //LOGIN + LOGOUT
        public void LoginLogout()
        {
            var loginPage = new LoginPage(Driver);
            var Loginform = loginPage.LoginForm();
            var LoginPassAndSubmit = loginPage.LoginPassAndSubmit(user);
            //var accountPage = new AccountPage(Driver);
            //var Logout = AccountPage.Logout();
        }
    }
}
