using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace PinnacleFrameworkExcercise.PageObjects
{
    class DynamicContentPageObject
    {
        private readonly IWebDriver _driver;

        public DynamicContentPageObject(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(this._driver, this);
        }

        public IReadOnlyCollection<IWebElement> GetImageList()
        {
           IReadOnlyCollection<IWebElement> imageList = this._driver.FindElements(By.TagName("img"));
            return imageList;
        }

    }
}
