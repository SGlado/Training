using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Travels_Test.Framework;
using Travels_Test.PageObjects;

namespace Travels_Test.Tests
{
    [TestClass]
    public class LanguageTests : BaseTest
    {
  
        [TestMethod] //CHANGE LANGUAGE TO ARABIC
        public void LanguageArabic()
        {
            var Language = new Language(Driver);
            var arabicLanguage = Language.Arabic();
        }
        [TestMethod] //CHANGE LANGUAGE TO TURKISH
        public void LanguageTurkish()
        {
            var Language = new Language(Driver);
            var turkishLanguage = Language.Turkish();
        }
        [TestMethod] //CHANGE LANGUAGE TO FRENCH
        public void LanguageFrench()
        {
            var Language = new Language(Driver);
            var frenchLanguage = Language.French();
        }
        [TestMethod] //CHANGE LANGUAGE TO SPANISH
        public void LanguageSpanish()
        {
            var Language = new Language(Driver);
            var spanishLanguage = Language.Spanish();
        }
        [TestMethod] //CHANGE LANGUAGE TO RUSSIAN
        public void LanguageRussian()
        {
            var Language = new Language(Driver);
            var russianLanguage = Language.Russian();
        }
        [TestMethod] //CHANGE LANGUAGE TO ENGLISH
        public void LanguageEnglish()
        {
            var Language = new Language(Driver);
            var englishLanguage = Language.English();
        }
    }
}
