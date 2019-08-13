using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PinnacleFrameworkExcercise.PageObjects
{
    public class DissapearingElementsPageObject
    {
        IWebDriver driver;

        public DissapearingElementsPageObject(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#content > div > ul > li:nth-child(5) > a")]
        public IWebElement GalleryButton;
    }
}
