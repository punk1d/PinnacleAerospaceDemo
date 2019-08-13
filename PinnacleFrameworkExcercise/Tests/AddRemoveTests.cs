using PinnacleFrameworkExcercise.CucumberActions;
using PinnacleFrameworkExcercise.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace PinnacleFrameworkExcercise.Tests
{
    [TestClass]
    public class AddRemoveTests : Setup
    {
        AddRemovePageObject addRemovePage;

        [TestMethod]
        [Description("User clicks Add Button 20 times")]
        public void AddElements()
        {
            
            addRemovePage = new AddRemovePageObject(driver);
            Given.UserEntersPage("https://ss-testing-automated-exercise.herokuapp.com/add_remove_elements/", driver);
             var res = When.UserAddsMultipleElements(addRemovePage.addButton, 20);
            Assert.AreEqual(0, res); //If res == 0 means no more elements are left to be added
        }

        [TestMethod]
        [Description("Verify Delete Button appeared 20 times")]
        public void VerifyElementsArePresent()
        {
            addRemovePage = new AddRemovePageObject(driver);
            Given.UserEntersPage("https://ss-testing-automated-exercise.herokuapp.com/add_remove_elements/", driver);
            When.UserAddsMultipleElements(addRemovePage.addButton, 20);
            var res = When.UserCountsDeleteButtons(driver);
            Assert.AreEqual(20, res);
        }

        [TestMethod]
        [Description("Verify Delete Buttons can be removed one by one")]
        public void VerifyDeletebuttonsCanBeRemoved()
        {
            addRemovePage = new AddRemovePageObject(driver);
            Given.UserEntersPage("https://ss-testing-automated-exercise.herokuapp.com/add_remove_elements/", driver);
            When.UserAddsMultipleElements(addRemovePage.addButton, 20);
            Assert.AreEqual(0, When.UserRemovesMultipleDeleteButtons(addRemovePage.removeButton, 20));
        }

        [TestMethod]
        [Description("Verify Delete Buttons were completely removed from the UI")]
        public void VerifyDeletebuttonsAreRemovedFromUI()
        {
            addRemovePage = new AddRemovePageObject(driver);
            Given.UserEntersPage("https://ss-testing-automated-exercise.herokuapp.com/add_remove_elements/", driver);
            When.UserAddsMultipleElements(addRemovePage.addButton, 20);
            When.UserRemovesMultipleDeleteButtons(addRemovePage.removeButton, 20);
            Assert.AreEqual(false, When.UserVerifiesThatElementsAreCompletelyRemoved(addRemovePage.removeButton));
        }
    }
}
