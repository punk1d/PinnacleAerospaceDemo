using PinnacleFrameworkExcercise.CucumberActions;
using PinnacleFrameworkExcercise.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PinnacleFrameworkExcercise.Tests
{
    [TestClass]
    public class MultipleWindowsTests : Setup
    {
        MultipleWindowsPageObject page;

        [TestMethod]
        public void VerifyMessageThroughMultipleWindows()
        {
            page = new MultipleWindowsPageObject(driver);
            Given.UserEntersPage("https://ss-testing-automated-exercise.herokuapp.com/windows", driver);
            page.link.Click();
            When.JustWaitSomeTime(driver, 2);
            var message = page.message.Text;
            Assert.IsTrue(condition: Then.messageIsDisplayed("New Window", page.message));
        }
    }
}
