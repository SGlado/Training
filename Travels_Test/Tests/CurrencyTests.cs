using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
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
        }
        [TestMethod] //CHANGE CURRENCY TO GBP
        public void CurrencyGBP()
        {
            var Currency = new Currency(Driver);
            Currency.ChangeCurrency("GBP");
        }

        [TestMethod] //CHANGE CURRENCY TO SAR
        public void CurrencySAR()
        {
            var Currency = new Currency(Driver);
            Currency.ChangeCurrency("SAR");
        }

        [TestMethod] //CHANGE CURRENCY TO EUR
        public void CurrencyEUR()
        {
            var Currency = new Currency(Driver);
            Currency.ChangeCurrency("EUR");
        }
        [TestMethod] //CHANGE CURRENCY TO JPY
        public void CurrencyJPY()
        {
            var Currency = new Currency(Driver);
            Currency.ChangeCurrency("JPY");
        }
        [TestMethod] //CHANGE CURRENCY TO INR
        public void CurrencyINR()
        {
            var Currency = new Currency(Driver);
            Currency.ChangeCurrency("INR");
        }
        [TestMethod] //CHANGE CURRENCY TO CNY
        public void CurrencyCNY()
        {
            var Currency = new Currency(Driver);
            Currency.ChangeCurrency("CNY");
        }

        [TestMethod] //CHANGE CURRENCY TO TRY
        public void CurrencyTRY()
        {
            var Currency = new Currency(Driver);
            Currency.ChangeCurrency("TRY");
            Assert.AreEqual("TRY" , Currency.CurrencyDropdown.Text, "Currency wasn't change to preffered on (TRY)");
        }
    }
}
