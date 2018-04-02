using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Language.ChangeLanguage("ARABIC");
        }
        [TestMethod] //CHANGE LANGUAGE TO TURKISH
        public void LanguageTurkish()
        {
            var Language = new Language(Driver);
            Language.ChangeLanguage("TURKISH");
        }
        [TestMethod] //CHANGE LANGUAGE TO FRENCH
        public void LanguageFrench()
        {
            var Language = new Language(Driver);
            Language.ChangeLanguage("FRENCH");
        }
        [TestMethod] //CHANGE LANGUAGE TO SPANISH
        public void LanguageSpanish()
        {
            var Language = new Language(Driver);
            Language.ChangeLanguage("SPANISH");
        }
        [TestMethod] //CHANGE LANGUAGE TO RUSSIAN
        public void LanguageRussian()
        {
            var Language = new Language(Driver);
            Language.ChangeLanguage("RUSSIAN");
        }
        [TestMethod] //CHANGE LANGUAGE TO ENGLISH
        public void LanguageEnglish()
        {
            var Language = new Language(Driver);
            Language.ChangeLanguage("ENGLISH");
        }
    }
}
