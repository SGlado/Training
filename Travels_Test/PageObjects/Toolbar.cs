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
    class Currency
    {
        protected IWebDriver Driver { get; set; }
        public Currency(IWebDriver driver)
        {
            Driver = driver;
        }
        public IWebElement CurrencyDropdown => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//li[@id='li_myaccount']/following-sibling::li"));
        internal Currency ChangeCurrency(string newCurrency)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(p => CurrencyDropdown.Displayed == true);
            CurrencyDropdown.Click();

            Driver.FindElement(By.XPath(String.Format("//div[@class='tbar-top hidden-sm hidden-xs']//a[@onclick='change_currency(this)' and contains(text(), '{0}') ]", newCurrency))).Click();
            return new Currency(Driver);
        }
    }
    class Language
    {
        protected IWebDriver Driver { get; set; }
        public Language(IWebDriver driver)
        {
            Driver = driver;
        }
        public IWebElement LanduageDropdown => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//li[@id='li_myaccount']/following-sibling::ul"));
        internal Language ChangeLanguage(string newLanguage)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(p => LanduageDropdown.Displayed == true);
            LanduageDropdown.Click();

            Driver.FindElement(By.XPath(String.Format("//div[@class='tbar-top hidden-sm hidden-xs']//a[@class='go-text-right changelang' and contains(text(), '{0}') ]", newLanguage))).Click();
            return new Language(Driver);
        }
    }
}
