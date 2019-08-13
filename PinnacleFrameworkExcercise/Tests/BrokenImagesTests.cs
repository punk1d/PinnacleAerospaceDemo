using PinnacleFrameworkExcercise.CucumberActions;
using PinnacleFrameworkExcercise.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace PinnacleFrameworkExcercise.Tests
{

    [TestClass]
    public class BrokenImagesTests : Setup
    {
        BrokenImagesPageObject brokenImagesPage;

        [TestMethod]
        [Description("Verifies how many broken images there are")]
        public async Task VerifyBrokenImages()
        {
            brokenImagesPage = new BrokenImagesPageObject(driver);
            Given.UserEntersPage("https://ss-testing-automated-exercise.herokuapp.com/broken_images", driver);
            int totalBrokenImages = brokenImagesPage.images.Count - await When.UserGetsTotalBrokenImages(brokenImagesPage.images);
            Assert.AreEqual(2, totalBrokenImages);
        }

        [TestMethod]
        [Description("Verifies how many good images there are")]
        public async Task VerifyGoodImages()
        {
            brokenImagesPage = new BrokenImagesPageObject(driver);
            Given.UserEntersPage("https://ss-testing-automated-exercise.herokuapp.com/broken_images", driver);
            int totalGoodImages = await When.UserGetsTotalBrokenImages(brokenImagesPage.images);
            Assert.AreEqual(1, totalGoodImages);
        }
    }
}
