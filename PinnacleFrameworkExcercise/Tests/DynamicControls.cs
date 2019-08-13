using PinnacleFrameworkExcercise.CucumberActions;
using PinnacleFrameworkExcercise.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PinnacleFrameworkExcercise.Tests
{
    [TestClass]
    public class DynamicControls : Setup
    {
        DynamicControlsPageObject page;


        [TestMethod]
        public void VerifyDynamicControlsFeature()
        {
            page = new DynamicControlsPageObject(driver);
            Given.GetUrl("https://ss-testing-automated-exercise.herokuapp.com/dynamic_controls", driver);
            When.UserClicksOnButton(page.button);
            Then.JustWaitSomeTime(driver, 5);
            var result = Then.UserVerifiesCheckboxMessage(page.message);
            When.UserClicksOnButton(page.enableButton);
            Then.JustWaitSomeTime(driver, 5);
            var x = page.inputTextbox.Enabled;
            Assert.AreEqual(result, Then.UserVerifiesElementIsEnabled(page.inputTextbox));
        }
    }
}
