using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PinnacleFrameworkExcercise.PageObjects
{
    class HomeBasicAuthPageObject
    {
        IWebDriver driver;

        public HomeBasicAuthPageObject(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/p")]
        public IWebElement successMessage;
    }
}
