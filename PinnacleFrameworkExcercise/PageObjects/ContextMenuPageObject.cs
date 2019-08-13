using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PinnacleFrameworkExcercise.PageObjects
{
    class ContextMenuPageObject
    {
        IWebDriver driver;

        public ContextMenuPageObject(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.Id, Using = "hot-spot")]
        public IWebElement contextBox;
    }
}
