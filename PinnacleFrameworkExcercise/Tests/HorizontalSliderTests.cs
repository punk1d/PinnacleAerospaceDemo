using PinnacleFrameworkExcercise.CucumberActions;
using PinnacleFrameworkExcercise.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PinnacleFrameworkExcercise.Tests
{
    [TestClass]
    public class HorizontalSliderTests : Setup
    {
        HorizontalSliderPageObject page;

        [TestMethod]
        public void ValidateSliderFeature()
        {
            page = new HorizontalSliderPageObject(driver);
            Given.GetUrl("https://ss-testing-automated-exercise.herokuapp.com/horizontal_slider", driver);
            page.slider.Click();
            var actualSliderValue = Given.GetElementText(page.sliderValueSelected);
            When.UserMovesSliderToValue(page.slider, 3.5, double.Parse(actualSliderValue), driver);
            page = new HorizontalSliderPageObject(driver);
            actualSliderValue = Given.GetElementText(page.sliderValueSelected);
            Assert.AreEqual("3.5",actualSliderValue);
        }
    }
}
