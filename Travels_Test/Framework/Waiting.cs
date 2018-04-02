using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Travels_Test.Framework
{
    public static class Waiting
    {
        //protected IWebDriver Driver { get; set; }
        
        //public Waiting(IWebDriver driver)
        //{
        //    Driver = driver;
        //}
        public static bool WaitForMePresent(this IWebElement driver, IWebElement elementToBePresent, int seconds = 30)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            try
            {
                wait.Until(p => elementToBePresent.Displayed == true);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
