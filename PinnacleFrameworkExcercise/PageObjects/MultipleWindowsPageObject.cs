using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PinnacleFrameworkExcercise.PageObjects
{
    class MultipleWindowsPageObject
    {
        private readonly IWebDriver _driver;

        public  MultipleWindowsPageObject(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/a")]
        public IWebElement link;

        
        public IWebElement message {
            get
            {
                return _driver.FindElement(By.XPath("/html/body/div/h3"));
            } }
    }
}
