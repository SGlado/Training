using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using Travels_Test.Framework;
using Travels_Test.PageObjects;

namespace Travels_Test.Tests
{
    [TestFixture]
    public class LanguageTests : BaseTest
    {
        [TestCase("Arabic", "ARABIC")]
        [TestCase("Turkish", "TURKISH")]
        [TestCase("French", "FRENCH")]
        [TestCase("Spanish", "SPANISH")]
        [TestCase("Russian", "RUSSIAN")]
        [TestCase("English", "ENGLISH")]
        [Test]
            public void LanguageTest(string language, string expected)
            {
                var Language = new Language(Driver);
                Language.ChangeLanguage(language);
                Driver.WaitForMeDisplayed(Language.LanguageDropdown, 20);
                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
                wait.Until(p => Language.LanguageDropdown.Text == expected);
                Assert.AreEqual(expected, Language.LanguageDropdown.Text, "Language wasn't change to preffered on " + Language);
            }
        }
    }
