using PinnacleFrameworkExcercise.CucumberActions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PinnacleFrameworkExcercise.PageObjects;

namespace PinnacleFrameworkExcercise.Tests
{
    [TestClass]
    public class CheckboxesTest : Setup
    {
        CheckboxPageObjects checkboxPage;
  
        [TestMethod]
        public void VerifyCheckBox1IsChecked()
        {
            checkboxPage = new CheckboxPageObjects(driver);
            Given.GetUrl("https://ss-testing-automated-exercise.herokuapp.com/checkboxes", driver);
            When.CheckboxIsClicked(checkboxPage.checkbox1);
            Assert.AreEqual("true", Then.VerifyCheckboxIsChecked(checkboxPage.checkbox1));
        }

        [TestMethod]
        public void VerifyCheckBoxesAreChecked()
        {
            checkboxPage = new CheckboxPageObjects(driver);
            Given.GetUrl("https://ss-testing-automated-exercise.herokuapp.com/checkboxes", driver);
            When.CheckboxIsClicked(checkboxPage.checkbox1);
            Assert.AreEqual(Then.VerifyCheckboxIsChecked(checkboxPage.checkbox1), Then.VerifyCheckboxIsChecked(checkboxPage.checkbox2));
        }
    }
}
