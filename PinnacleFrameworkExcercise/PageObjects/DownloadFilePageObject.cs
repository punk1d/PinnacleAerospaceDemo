using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PinnacleFrameworkExcercise.PageObjects
{
    class DownloadFilePageObject
    {
        private readonly IWebDriver _driver;

        public DownloadFilePageObject(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/a")]
        public IWebElement downloadLink;
    }
}
