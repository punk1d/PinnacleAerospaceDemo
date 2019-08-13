using PinnacleFrameworkExcercise.CucumberActions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PinnacleFrameworkExcercise.PageObjects;

namespace PinnacleFrameworkExcercise.Tests
{
    [TestClass]
    public class DragAndDropTests : Setup
    {
        DragAndDropPageObject DDPage;

        [TestMethod]
        public void ValidateDDFeature()
        {
            DDPage = new DragAndDropPageObject(driver);
            Given.GetUrl("https://ss-testing-automated-exercise.herokuapp.com/drag_and_drop",driver);
            When.UserDragsElementAToB(DDPage.columnA, DDPage.columnB, driver);
            var result = Then.UserVerifiesAIsNowInB(DDPage.columnA);
            When.UserDragsElementAToB(DDPage.columnA, DDPage.columnB, driver);
            result = Then.UserVerifiesAIsNowInB(DDPage.columnB);
            Assert.IsTrue(result);
        }
    }
}
