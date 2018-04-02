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
            Language.ChangeLanguage("Arabic");
            Assert.AreEqual("ARABIC", Language.LanduageDropdown.Text, "Currency wasn't change to preffered on (Arabic)");
        }
        [TestMethod] //CHANGE LANGUAGE TO TURKISH
        public void LanguageTurkish()
        {
            var Language = new Language(Driver);
            Language.ChangeLanguage("Turkish");
            Assert.AreEqual("TURKISH", Language.LanduageDropdown.Text, "Currency wasn't change to preffered on (Turkish)");
        }
        [TestMethod] //CHANGE LANGUAGE TO FRENCH
        public void LanguageFrench()
        {
            var Language = new Language(Driver);
            Language.ChangeLanguage("French");
            Assert.AreEqual("FRENCH", Language.LanduageDropdown.Text, "Currency wasn't change to preffered on (French)");
        }
        [TestMethod] //CHANGE LANGUAGE TO SPANISH
        public void LanguageSpanish()
        {
            var Language = new Language(Driver);
            Language.ChangeLanguage("Spanish");
            Assert.AreEqual("SPANISH", Language.LanduageDropdown.Text, "Currency wasn't change to preffered on (Spanish)");
        }
        [TestMethod] //CHANGE LANGUAGE TO RUSSIAN
        public void LanguageRussian()
        {
            var Language = new Language(Driver);
            Language.ChangeLanguage("Russian");
            Assert.AreEqual("RUSSIAN", Language.LanduageDropdown.Text, "Currency wasn't change to preffered on (Russian)");
        }
        [TestMethod] //CHANGE LANGUAGE TO ENGLISH
        public void LanguageEnglish()
        {
            var Language = new Language(Driver);
            Language.ChangeLanguage("English");
            Assert.AreEqual("ENGLISH", Language.LanduageDropdown.Text, "Currency wasn't change to preffered on (English)");
        }
    }
}
