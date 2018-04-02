using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Travels_Test.PageObjects
{
    class Currency
    {
        protected IWebDriver Driver { get; set; }
        public Currency(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebElement CurrencyDropdown => Driver.FindElement(By.XPath("//div[@class='tbar-top hidden-sm hidden-xs']//li[@id='li_myaccount']/following-sibling::li"));

        //internal Currency USD()
        //{
        //    WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        //    wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/a/strong")).Displayed == true);
        //    Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/a/strong")).Click();
        //    wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/ul/li[1]/a")).Displayed == true);
        //    Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/ul/li[1]/a")).Click();
        //    return new Currency(Driver);
        //}
        //internal Currency GBP()
        //{
        //    WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        //    wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/a/strong")).Displayed == true);
        //    Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/a/strong")).Click();
        //    wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/ul/li[2]/a")).Displayed == true);
        //    Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/ul/li[2]/a")).Click();
        //    return new Currency(Driver);
        //}
        //internal Currency SAR()
        //{
        //    WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        //    wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/a/strong")).Displayed == true);
        //    Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/a/strong")).Click();
        //    wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/ul/li[3]/a")).Displayed == true);
        //    Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/ul/li[3]/a")).Click();
        //    return new Currency(Driver);
        //}
        //internal Currency EUR()
        //{
        //    WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        //    wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/a/strong")).Displayed == true);
        //    Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/a/strong")).Click();
        //    wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/ul/li[4]/a")).Displayed == true);
        //    Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/ul/li[4]/a")).Click();
        //    return new Currency(Driver);
        //}
        //internal Currency JPY()
        //{
        //    WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        //    wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/a/strong")).Displayed == true);
        //    Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/a/strong")).Click();
        //    wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/ul/li[5]/a")).Displayed == true);
        //    Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/ul/li[5]/a")).Click();
        //    return new Currency(Driver);
        //}
        //internal Currency INR()
        //{
        //    WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        //    wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/a/strong")).Displayed == true);
        //    Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/a/strong")).Click();
        //    wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/ul/li[6]/a")).Displayed == true);
        //    Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/ul/li[6]/a")).Click();
        //    return new Currency(Driver);
        //}
        //internal Currency CNY()
        //{
        //    WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        //    wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/a/strong")).Displayed == true);
        //    Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/a/strong")).Click();
        //    wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/ul/li[7]/a")).Displayed == true);
        //    Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/ul/li[7]/a")).Click();
        //    return new Currency(Driver);
        //}
        //internal Currency TRY()
        //{
        //    WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        //    wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/a/strong")).Displayed == true);
        //    Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/a/strong")).Click();
        //    wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/ul/li[8]/a")).Displayed == true);
        //    Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/li[2]/ul/li[8]/a")).Click();
        //    return new Currency(Driver);
        //}

        internal Currency ChangeCurrency(string newCurrency)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(p => CurrencyDropdown.Displayed == true);
            CurrencyDropdown.Click();

            Driver.FindElement(By.XPath(String.Format("//div[@class='tbar-top hidden-sm hidden-xs']//a[@onclick='change_currency(this)' and contains(text(), '{0}') ]", newCurrency))).Click();
            return new Currency(Driver);
        }
    }
}