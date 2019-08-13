using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace PinnacleFrameworkExcercise.PageObjects
{
    class BrokenImagesPageObject
    {
        IWebDriver driver;

        public BrokenImagesPageObject (IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);                       
        }


        public IReadOnlyCollection<IWebElement> images
        {
            get
            {
                return driver.FindElements(By.XPath("/html/body/div[2]/div/div/img"));
            }
        }
    }
}
