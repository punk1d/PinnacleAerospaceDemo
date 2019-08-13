using PinnacleFrameworkExcercise.CucumberActions;
using PinnacleFrameworkExcercise.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PinnacleFrameworkExcercise.Tests
{
    [TestClass]
    public class OutOfViewPortTests : Setup
    {
        OutOfViewPortPageObject Page;

        [TestMethod]
        public void ValidateModalIsDisplayed()
        {
            Page = new OutOfViewPortPageObject(driver);
            Given.GetUrl("https://ss-testing-automated-exercise.herokuapp.com/exit_intent", driver);
            When.UserMovesMouseOutOfViewPort();
            Assert.IsTrue(Then.IsDisplayed(Page.modal));
        }

    }
}
