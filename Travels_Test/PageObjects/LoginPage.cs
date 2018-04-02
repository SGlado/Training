using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Travels_Test.PageObjects
{
    class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        protected IWebDriver Driver { get; set; }

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
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(p => LoginField.Displayed == true);
            LoginField.SendKeys(user.Login);
            PasswordField.SendKeys(user.Password);
            wait.Until(p => PasswordField.Displayed == true);
            LoginButton.Click();
            return new LoginPage(Driver);
        }
    }
}
