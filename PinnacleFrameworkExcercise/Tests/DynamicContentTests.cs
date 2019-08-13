using PinnacleFrameworkExcercise.CucumberActions;
using PinnacleFrameworkExcercise.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PinnacleFrameworkExcercise.Tests
{
    [TestClass]
    public class DynamicContentTests : Setup
    {
        DynamicContentPageObject page;

        [TestMethod]
        public void ImagesAppearedAtLeastOneTime()
        {
            page = new DynamicContentPageObject(driver);
            Given.GetUrl("https://ss-testing-automated-exercise.herokuapp.com/dynamic_content", driver);
            var imageNames = When.UserRefreshPageUntilImagesAreDisplayed(page.GetImageList(), driver);
            var expectedResult = new List<string>(new string[] { "https://ss-testing-automated-exercise.herokuapp.com/img/avatars/Original-Facebook-Geek-Profile-Avatar-5.jpg",
                "https://ss-testing-automated-exercise.herokuapp.com/img/avatars/Original-Facebook-Geek-Profile-Avatar-2.jpg",
                "https://ss-testing-automated-exercise.herokuapp.com/img/avatars/Original-Facebook-Geek-Profile-Avatar-7.jpg",
                "https://ss-testing-automated-exercise.herokuapp.com/img/avatars/Original-Facebook-Geek-Profile-Avatar-1.jpg",
                "https://ss-testing-automated-exercise.herokuapp.com/img/avatars/Original-Facebook-Geek-Profile-Avatar-3.jpg" });
            imageNames.Sort();
            expectedResult.Sort();
            Assert.AreEqual(imageNames, expectedResult); //Review
        }
    }
}
