using PinnacleFrameworkExcercise.CucumberActions;
using PinnacleFrameworkExcercise.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PinnacleFrameworkExcercise.Tests
{
    [TestClass]
    public class FloatingMenuTests : Setup
    {
        Given given = new Given();
        When when = new When();
        Then then = new Then();
        FloatingMenuPageObjects page;


        [TestMethod]
        public void ValidateFloatingMenu()
        {
            page = new FloatingMenuPageObjects(driver);
            Given.GetUrl("https://ss-testing-automated-exercise.herokuapp.com/floating_menu", driver);
            When.UserScrollToBottom(driver, page.footer);
            Assert.IsTrue(condition: Then.IsDisplayed(page.floatingMenu)); //page.floatingMenu.GetAttribute("") > 5000
        }
    }
}
