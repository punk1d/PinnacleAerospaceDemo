using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PinnacleFrameworkExcercise.PageObjects
{
    class FloatingMenuPageObjects
    {
        private readonly IWebDriver _driver;

        public FloatingMenuPageObjects(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/h3")]
        public IWebElement floatingMenu;

        [FindsBy(How = How.Id, Using = "page-footer")]
        public IWebElement footer;
        
    }
}
