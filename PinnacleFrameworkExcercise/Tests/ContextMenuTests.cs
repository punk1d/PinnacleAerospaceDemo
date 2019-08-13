using PinnacleFrameworkExcercise.CucumberActions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PinnacleFrameworkExcercise.PageObjects;

namespace PinnacleFrameworkExcercise.Tests
{
    [TestClass]
    public class ContextMenuTests : Setup
    {
        ContextMenuPageObject contextPage;

        [TestMethod]
        public void VerifyContextMenuFeature()
        {
            contextPage = new ContextMenuPageObject(driver);
            Given.GetUrl("https://ss-testing-automated-exercise.herokuapp.com/context_menu", driver);
            When.UserRightClicksOnContextMenu(contextPage.contextBox, driver);
            var result = Then.VerifyMessageInAlert("You selected a context menu", driver);
            result = Then.VerifyAlertIsClosed(driver);
            Assert.IsTrue(result);
        }
    }
}
