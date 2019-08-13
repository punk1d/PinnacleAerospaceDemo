using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PinnacleFrameworkExcercise.PageObjects
{
    class DragAndDropPageObject
    {
        IWebDriver _driver;

        public DragAndDropPageObject(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(this._driver, this);
        }

        [FindsBy(How = How.Id, Using = ("column-a"))]
        public IWebElement columnA;

        [FindsBy(How = How.Id, Using = ("column-b"))]
        public IWebElement columnB;

    }
}
