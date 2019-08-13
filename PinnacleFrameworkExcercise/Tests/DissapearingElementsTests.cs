using PinnacleFrameworkExcercise.CucumberActions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PinnacleFrameworkExcercise.PageObjects;

namespace PinnacleFrameworkExcercise.Tests
{
    [TestClass]
    public class DissapearingElementsTests : Setup
    {
        DissapearingElementsPageObject page;

        [TestMethod]
        public void ValidateGalleryButtonIsPresent()
        {
            page = new DissapearingElementsPageObject(driver);
            Given.GetUrl("https://ss-testing-automated-exercise.herokuapp.com/disappearing_elements", driver);
            var isDisplayed = When.UserChecksUntilElementIsPresent(page.GalleryButton, driver);
            When.JustWaitSomeTime(driver, 5);
            Assert.IsTrue(isDisplayed);
        }

        [TestMethod]
        public void ValidateGalleryButtonIsNotPresent()
        {
            page = new DissapearingElementsPageObject(driver);
            Given.GetUrl("https://ss-testing-automated-exercise.herokuapp.com/disappearing_elements", driver);
            var isNotDisplayed = When.UserChecksUntilElementIsNoLongerPresent(page.GalleryButton, driver);
            When.JustWaitSomeTime(driver, 5);
            Assert.IsTrue(isNotDisplayed);
        }
    }
}
