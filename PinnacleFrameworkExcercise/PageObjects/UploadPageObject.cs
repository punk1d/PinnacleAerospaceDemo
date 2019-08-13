using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PinnacleFrameworkExcercise.PageObjects
{
    class UploadPageObject: Setup
    {
        private readonly IWebDriver _driver;

        public UploadPageObject(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "file-upload")]
        public IWebElement browserButton;

        [FindsBy(How = How.Id, Using = "file-submit")]
        public IWebElement uploadButton;

        [FindsBy(How = How.CssSelector, Using = "html.no-js body div.row div#content.large-12.columns div.example h3")]
        public IWebElement successMessage;
    }
}
