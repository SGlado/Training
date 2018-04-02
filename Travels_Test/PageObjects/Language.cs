using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travels_Test.PageObjects
{
    class Language
    {
        protected IWebDriver Driver { get; set; }
        public Language(IWebDriver driver)
        {
            Driver = driver;
        }
        internal Language Arabic()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li")).Displayed == true);
            Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li")).Click();
            wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li/ul/li[1]")).Displayed == true);
            Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li/ul/li[1]")).Click();
            return new Language(Driver);
        }
        internal Language Turkish()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li")).Displayed == true);
            Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li")).Click();
            wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li/ul/li[2]")).Displayed == true);
            Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li/ul/li[2]")).Click();
            return new Language(Driver);
        }
        internal Language French()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li")).Displayed == true);
            Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li")).Click();
            wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li/ul/li[3]")).Displayed == true);
            Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li/ul/li[3]")).Click();
            return new Language(Driver);
        }
        internal Language Spanish()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li")).Displayed == true);
            Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li")).Click();
            wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li/ul/li[4]")).Displayed == true);
            Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li/ul/li[4]")).Click();
            return new Language(Driver);
        }
        internal Language Russian()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li")).Displayed == true);
            Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li")).Click();
            wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li/ul/li[5]")).Displayed == true);
            Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li/ul/li[5]")).Click();
            return new Language(Driver);
        }
        internal Language English()
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li")).Displayed == true);
            Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li")).Click();
            wait.Until(p => Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li/ul/li[6]")).Displayed == true);
            Driver.FindElement(By.XPath("/html/body/div[4]/div/div/div[2]/ul/ul/li/ul/li[6]")).Click();
            return new Language(Driver);
        }
    }
}
