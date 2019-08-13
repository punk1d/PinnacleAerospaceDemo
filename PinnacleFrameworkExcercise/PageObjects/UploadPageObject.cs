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

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/h3")]
        public IWebElement successMessage;
    }
}
