using OpenQA.Selenium;
using System.Threading;
using Travels_Test.Framework;

namespace Travels_Test.PageObjects
{
    class LoginPage : BaseTest
    {
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }
        //Login Form
        public IWebElement LoginField => Driver.FindElement(By.XPath("//input[@placeholder='Email']"));
        public IWebElement PasswordField => Driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        public IWebElement LoginButton => Driver.FindElement(By.XPath("//*[@id='loginfrm']//button[text()='Login']"));
        //Tool bar item
        public IWebElement MyAccountButton => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//*[text()=' My Account ']"));
        public IWebElement LoginToolbarButton => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//*[text()=' Login']"));

        internal LoginPage LoginForm()
        {
            MyAccountButton.Click();
            LoginToolbarButton.Click();
            return new LoginPage(Driver);
        }
        internal LoginPage LoginPassAndSubmit(TestUserCredentials user)
        {
            LoginField.SendKeys(user.Login);
            PasswordField.SendKeys(user.Password);
            LoginButton.Click();
            return new LoginPage(Driver);
        }
        //internal AccountPage Logout()
        //{
        //    //Driver.WaitForMeDisplayed(Logout.AccountDropdown, 20);
        //    ////WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        //    ////wait.Until(p => AccountDropdown.Displayed == true);
        //    //Thread.Sleep(3000);
        //    //AccountDropdown.Click();
        //    //wait.Until(p => LogoutButton.Displayed == true);
        //    LogoutButton.Click();
        //    Driver.Navigate().GoToUrl("https://www.phptravels.net/");
        //    return new AccountPage(Driver);
        //}
    }
}
