using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PinnacleFrameworkExcercise.PageObjects
{
    class JSAlertsPageObject
    {
        private readonly IWebDriver _driver;

        public JSAlertsPageObject(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = ".example > ul:nth-child(3) > li:nth-child(1) > button:nth-child(1)")]
        public IWebElement JsAlertButton;

        [FindsBy(How = How.CssSelector, Using = ".example > ul:nth-child(3) > li:nth-child(3) > button:nth-child(1)")]
        public IWebElement JsPromptButton;

        [FindsBy(How = How.Id, Using = "result")]
        public IWebElement messageText;
    }
}
