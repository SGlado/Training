using NUnit.Framework;
using Travels_Test.PageObjects;
using Travels_Test.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace Travels_Test.Tests
{
    [TestFixture]
    
    public class LoginLogout_Test : BaseTest
    {
        [Test] //LOGIN + LOGOUT
        public void LoginLogout()
        {
            var loginPage = new LoginLogoutPage(Driver);
            var Loginform = loginPage.LoginForm();
            var LoginPassAndSubmit = loginPage.LoginPassAndSubmit(user);
            //Thread.Sleep(1000);
            Driver.WaitForMeDisplayed(Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//*[text()=' DVhbCERv ']")), 20);
            Assert.IsTrue(Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//*[text()=' DVhbCERv ']")).Displayed, "You wasn't logged in, incorrect username or password");
            var AccountPage = new LoginLogoutPage(Driver);
            Driver.WaitForMeDisplayed(AccountPage.AccountDropdown, 20);
            var Logout = AccountPage.Logout();
            Assert.IsTrue(Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//*[text()=' My Account ']")).Displayed, "Ooops! You wasn't logged out");
        }
    }
}
