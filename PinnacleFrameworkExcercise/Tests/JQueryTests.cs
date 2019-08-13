using PinnacleFrameworkExcercise.CucumberActions;
using PinnacleFrameworkExcercise.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PinnacleFrameworkExcercise.Tests
{
    [TestClass]
    public class JQueryTests : Setup
    {
        JQueryPageObject page;

        [TestMethod]
        public void VefiryFileIsDownloaded()
        {
            page = new JQueryPageObject(driver);
            Given.GetUrl("https://ss-testing-automated-exercise.herokuapp.com/jqueryui/menu#", driver);
            When.UserClicksOnButton(page.enabledButton);
            When.UserClicksOnButton(page.downloadsButton);
            When.UserClicksOnButton(page.excelButton);
            Assert.IsTrue(condition: Then.VerifyFileExists("menu.xls"));

        }
    }
}
