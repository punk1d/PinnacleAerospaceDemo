using PinnacleFrameworkExcercise.CucumberActions;
using PinnacleFrameworkExcercise.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PinnacleFrameworkExcercise.Tests
{
    [TestClass]
    public class DownloadFileTests : Setup
    {   
        DownloadFilePageObject page;

        [TestMethod]
        public void VerifyDowloadWasPerformed()
        {
            page = new DownloadFilePageObject(driver);
            Given.GetUrl("https://ss-testing-automated-exercise.herokuapp.com/download", driver);
            When.UserClicksOnButton(page.downloadLink);
            Assert.IsTrue(condition: Then.VerifyFileExists("some-file.txt"));
        }
    }
}
