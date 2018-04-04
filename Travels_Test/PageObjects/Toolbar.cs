using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Travels_Test.PageObjects
{
    ////CURRENCY////
    class Currency
    {
        protected IWebDriver Driver { get; set; }
        public Currency(IWebDriver driver)
        {
            Driver = driver;
        }
        public IWebElement CurrencyDropdown => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//li[@id='li_myaccount']/following-sibling::li[@class='dropdown']"));
        internal Currency ChangeCurrency(string newCurrency)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(p => CurrencyDropdown.Displayed == true);
            CurrencyDropdown.Click();
            wait.Until(p => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//ul[@class='dropdown-menu wow fadeIn animated']")).Displayed == true); 
            Driver.FindElement(By.XPath(String.Format("//div[@class='tbar-top hidden-sm hidden-xs']//a[@onclick='change_currency(this)' and contains(text(), '{0}') ]", newCurrency))).Click();
            return new Currency(Driver);
        }
    }
    ////LANGUAGE////
    class Language
    {
        protected IWebDriver Driver { get; set; }
        public Language(IWebDriver driver)
        {
            Driver = driver;
        }
        public IWebElement LanguageDropdown => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//li[@id='li_myaccount']/following-sibling::ul[@class='nav navbar-nav']")); 
        internal Language ChangeLanguage(string newLanguage)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(p => LanguageDropdown.Displayed == true);
            LanguageDropdown.Click();
            Driver.FindElement(By.XPath(String.Format("//div[@class='tbar-top hidden-sm hidden-xs']//a[@class='go-text-right changelang' and contains(text(), '{0}') ]", newLanguage))).Click();
            return new Language(Driver);
        }
    }
}
