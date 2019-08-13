using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PinnacleFrameworkExcercise.PageObjects
{
    class DynamicControlsPageObject
    {
        private IWebDriver _driver;

        public DynamicControlsPageObject(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(this._driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[1]/form[1]/button")]
        public IWebElement button;
        
        [FindsBy(How = How.Id, Using = "message")]
        public IWebElement message;

        [FindsBy(How = How.CssSelector, Using = "html.no-js body div.row div#content.large-12.columns div.example form#input-example button")]
        public IWebElement enableButton;

        [FindsBy(How = How.CssSelector, Using = "html.no-js body div.row div#content.large-12.columns div.example form#input-example input")]
        public IWebElement inputTextbox;

    }
}
