﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;

namespace Travels_Test.Framework
{
    [TestClass]
    public class BaseTest
    {
        internal TestUserCredentials user { get; private set; }

        protected IWebDriver GetChromeDriver()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(outPutDirectory);
        }

        public IWebDriver Driver { get; set; }
        public BaseTest(IWebDriver driver)
        {
            Driver = driver;
        }

        public BaseTest()
        {

        }

        [TestInitialize]
        public void SetupEverySingleClass()
        {
            Driver = GetChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.phptravels.net/");
            user = new TestUserCredentials();
            user.Login = "user@phptravels.com";
            user.Password = "demouser";
        }

        [TestCleanup]
        public void CleanupEverySinglClass()
        {
            Driver.Quit();
        }
    }
}