using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PinnacleFrameworkExcercise.PageObjects
{
    class HorizontalSliderPageObject
    {
        private readonly IWebDriver _driver;

        public HorizontalSliderPageObject(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".sliderContainer > input:nth-child(1)")]
        public IWebElement slider;

        [FindsBy(How = How.Id, Using = "range")]
        public IWebElement sliderValueSelected;

    }
}
