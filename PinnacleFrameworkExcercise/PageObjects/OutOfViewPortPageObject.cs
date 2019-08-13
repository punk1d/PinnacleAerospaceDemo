using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PinnacleFrameworkExcercise.PageObjects
{
    public class OutOfViewPortPageObject
    {
        public readonly IWebDriver _driver;

        public OutOfViewPortPageObject(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "modal")]
        public IWebElement modal;
    }
}
