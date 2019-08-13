using PinnacleFrameworkExcercise.CucumberActions;
using PinnacleFrameworkExcercise.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PinnacleFrameworkExcercise.Tests
{
    [TestClass]
    public class UploadTests : Setup
    {
        UploadPageObject page;

        [TestMethod]
        public void ValidateUploadFeature()
        {
            var userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\');
            string filePath = @"C:\Users\" + userName[1] + @"\Desktop\test.txt";
            page = new UploadPageObject(driver);
            Given.GetUrl("https://ss-testing-automated-exercise.herokuapp.com/upload", driver);
            Given.UserCreatesAFile(filePath);
            When.UserClicksOnButton(page.browserButton);
            When.UserEntersFilePath(filePath, driver);
            When.UserClicksOnButton(page.uploadButton);
            Assert.IsTrue(condition: Then.messageIsDisplayed("File Uploaded!", page.successMessage));
        }
    }
}
