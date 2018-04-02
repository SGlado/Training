using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System.Reflection;
using OpenQA.Selenium.Chrome;
using System.IO;
using Travels_Test.PageObjects;
using Travels_Test.Framework;

namespace Travels_Test.Tests
{
    [TestClass]
    
    public class Travel_Tests : BaseTest
    {
        [TestMethod] //LOGIN + LOGOUT
        public void LoginLogout()
        {
            var loginPage = new LoginPage(Driver);
            var Loginform = loginPage.LoginForm().LoginPassAndSubmit(user);
            var Login = loginPage.LoginPassAndSubmit(user);
            var accountPage = new AccountPage(Driver);
            var Logout = accountPage.Logout();
        }
      
    }
}
