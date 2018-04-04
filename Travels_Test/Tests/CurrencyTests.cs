using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using Travels_Test.Framework;
using Travels_Test.PageObjects;

namespace Travels_Test.Tests
{
    [TestFixture]
    public class CurrencyTests : BaseTest
    {
        [TestCase("USD", "USD")]
        [TestCase("GBP", "GBP")]
        [TestCase("SAR", "ل")]
        [TestCase("EUR", "EUR")]
        [TestCase("JPY", "JPY")]
        [TestCase("INR", "INR")]
        [TestCase("CNY", "CNY")]
        [TestCase("TRY", "TURKISH")]
        [Test]
            public void CurrencyTest(string currency, string expected)
            {
                var Currency = new Currency(Driver);
                Currency.ChangeCurrency(currency);
                Driver.WaitForMeDisplayed(Currency.CurrencyDropdown, 20);
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                wait.Until(p => Currency.CurrencyDropdown.Text == expected);
                Assert.AreEqual(expected, Currency.CurrencyDropdown.Text, "Currency wasn't change to preffered on " + currency);
            }
    }
}