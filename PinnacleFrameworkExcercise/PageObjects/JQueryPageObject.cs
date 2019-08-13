using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PinnacleFrameworkExcercise.PageObjects
{
    class JQueryPageObject
    {
        private readonly IWebDriver _driver;

        public JQueryPageObject(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#ui-id-3 > a:nth-child(2)")]
        public IWebElement enabledButton;

        [FindsBy(How = How.CssSelector, Using = "#ui-id-4 > a:nth-child(2)")]
        public IWebElement downloadsButton;

        [FindsBy(How = How.CssSelector, Using = "#ui-id-7 > a:nth-child(1)")]
        public IWebElement excelButton;
    }
}
