using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Travels_Test.PageObjects
{
    class AccountPage
    {
        protected IWebDriver Driver { get; set; }
        public AccountPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement AccountDropdown => Driver.FindElement(By.XPath("/ html / body / div[4] / div / div / div[2] / ul / li[1] / a"));
        public IWebElement LogoutButton => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//*[text()='  Logout']"));


        internal AccountPage Logout()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(p => AccountDropdown.Displayed == true);
            Thread.Sleep(3000);

            AccountDropdown.Click();

            wait.Until(p => LogoutButton.Displayed == true);
            LogoutButton.Click();
            Driver.Navigate().GoToUrl("https://www.phptravels.net/");
            return new AccountPage(Driver);
        }

    }
}
