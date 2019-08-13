using PinnacleFrameworkExcercise.CucumberActions;
using PinnacleFrameworkExcercise.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace PinnacleFrameworkExcercise.Tests
{
    [TestClass]
    public class KeyPressTests : Setup
    {
        KeyPressPageObject page;

        [TestMethod]
        public void VerifyKeyPressFeature()
        {
            page = new KeyPressPageObject(driver);
            Given.GetUrl("https://ss-testing-automated-exercise.herokuapp.com/key_presses", driver);
            page = new KeyPressPageObject(driver);
            page.textBox.SendKeys(Keys.Escape);
            var result = Then.USerVerifiesTextInElement("You entered: ESCAPE", page.message);
            page.textBox.SendKeys(Keys.Backspace);
            page = new KeyPressPageObject(driver);
            Assert.AreEqual(result, Then.USerVerifiesTextInElement("You entered: BACK_SPACE", page.message));
        }
    }
}
