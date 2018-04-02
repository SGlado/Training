using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;
using Travels_Test.Framework;
using Travels_Test.PageObjects;

namespace Travels_Test.Tests
{
    [TestClass]
    public class CurrencyTests : BaseTest
    {

        [TestMethod] //CHANGE CURRENCY TO USD
        public void CurrencyUSD()
        {
            var Currency = new Currency(Driver);
            Currency.ChangeCurrency("USD");
            Assert.AreEqual("USD", Currency.CurrencyDropdown.Text, "Currency wasn't change to preffered on (USD)");
        }
        [TestMethod] //CHANGE CURRENCY TO GBP
        public void CurrencyGBP()
        {
            var Currency = new Currency(Driver);
            Currency.ChangeCurrency("GBP");
            Assert.AreEqual("GBP", Currency.CurrencyDropdown.Text, "Currency wasn't change to preffered on (GBP)");
        }

        [TestMethod] //CHANGE CURRENCY TO SAR
        public void CurrencySAR()
        {
            var Currency = new Currency(Driver);
            Currency.ChangeCurrency("SAR");
            Assert.AreEqual("SAR", Currency.CurrencyDropdown.Text, "Currency wasn't change to preffered on (SAR)");
        }

        [TestMethod] //CHANGE CURRENCY TO EUR
        public void CurrencyEUR()
        {
            var Currency = new Currency(Driver);
            Currency.ChangeCurrency("EUR");
            Assert.AreEqual("EUR", Currency.CurrencyDropdown.Text, "Currency wasn't change to preffered on (EUR)");
        }
        [TestMethod] //CHANGE CURRENCY TO JPY
        public void CurrencyJPY()
        {
            var Currency = new Currency(Driver);
            Currency.ChangeCurrency("JPY");
            Assert.AreEqual("JPY", Currency.CurrencyDropdown.Text, "Currency wasn't change to preffered on (JPY)");
        }
        [TestMethod] //CHANGE CURRENCY TO INR
        public void CurrencyINR()
        {
            var Currency = new Currency(Driver);
            Currency.ChangeCurrency("INR");
            Assert.AreEqual("INR", Currency.CurrencyDropdown.Text, "Currency wasn't change to preffered on (INR)");
        }
        [TestMethod] //CHANGE CURRENCY TO CNY
        public void CurrencyCNY()
        {
            var Currency = new Currency(Driver);
            Currency.ChangeCurrency("CNY");
            Assert.AreEqual("CNY", Currency.CurrencyDropdown.Text, "Currency wasn't change to preffered on (CNY)");
        }

        [TestMethod] //CHANGE CURRENCY TO TRY
        public void CurrencyTRY()
        {
            var Currency = new Currency(Driver);
            Currency.ChangeCurrency("TRY");
            Thread.Sleep(3000);
            Assert.AreEqual("Turkish", 0, "Currency wasn't change to preffered on (TRY)");
        }
    }
}