using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PinnacleFrameworkExcercise.PageObjects
{
    class InvalidAuthPageObject
    {
        IWebDriver driver;

        public InvalidAuthPageObject(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body")]
        public IWebElement invalidAuthMessage;
    }
}
