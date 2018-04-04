using OpenQA.Selenium;
using System.Threading;
using Travels_Test.Framework;

namespace Travels_Test.PageObjects
{
    ////LOGIN-LOGOUT////
    //class AccountPage
    //{
    //    protected IWebDriver Driver { get; set; }
    //    public AccountPage(IWebDriver driver)
    //    {
    //        Driver = driver;
    //    }
    //    public IWebElement AccountDropdown => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//*[class='dropdown-menu']"));
    //    public IWebElement LogoutButton => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//*[text()='  Logout']"));
    //}
    class LoginLogoutPage : BaseTest
    {
        public LoginLogoutPage(IWebDriver driver)
        {
            Driver = driver;
        }
        public IWebElement Button_MyAccount => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//*[text()=' My Account ']"));
        public IWebElement Button_MyAccountLogin => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//*[text()=' Login']"));
        public IWebElement Field_UserName => Driver.FindElement(By.XPath("//input[@placeholder='Email']"));
        public IWebElement Field_UserPassword => Driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        public IWebElement Button_PushLogin => Driver.FindElement(By.XPath("//*[@id='loginfrm']//button[text()='Login']"));
        public IWebElement AccountDropdown => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//*[text()=' DVhbCERv ']"));
        public IWebElement Button_Logout => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//*[text()='  Logout']"));

        internal LoginLogoutPage LoginForm()
        {
            Button_MyAccount.Click();
            Button_MyAccountLogin.Click();
            return new LoginLogoutPage(Driver);
        }
        internal LoginLogoutPage LoginPassAndSubmit(TestUserCredentials user)
        {
            Field_UserName.SendKeys(user.Login);
            Field_UserPassword.SendKeys(user.Password);
            Thread.Sleep(1000);
            Button_PushLogin.Click();
            return new LoginLogoutPage(Driver);
        }
        internal LoginLogoutPage Logout()
        {
            Thread.Sleep(3000);
            //Driver.WaitForMeDisplayed(AccountDropdown, 20);
            AccountDropdown.Click();
            Button_Logout.Click();
            Driver.Navigate().GoToUrl("https://www.phptravels.net/");
            return new LoginLogoutPage(Driver);
        }
    }
}
