using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PinnacleFrameworkExcercise.PageObjects
{
    public class CheckboxPageObjects
    {
        IWebDriver driver;

        public CheckboxPageObjects(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(this.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#checkboxes > input:nth-child(1)")]
        public IWebElement checkbox1;

        [FindsBy(How = How.CssSelector, Using = "#checkboxes > input:nth-child(3)")]
        public IWebElement checkbox2;
    }
}
