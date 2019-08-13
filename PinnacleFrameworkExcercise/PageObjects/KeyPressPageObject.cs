using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PinnacleFrameworkExcercise.PageObjects
{
    class KeyPressPageObject
    {
        private readonly IWebDriver _driver;

        public KeyPressPageObject(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "target")]
        public IWebElement textBox;

        [FindsBy(How = How.Id, Using = "result")]
        public IWebElement message;
    }
}
