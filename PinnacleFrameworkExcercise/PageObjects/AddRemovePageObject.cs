using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;


namespace PinnacleFrameworkExcercise.PageObjects
{
    class AddRemovePageObject
    {
        IWebDriver driver;

        public AddRemovePageObject(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/button")]
        public IWebElement addButton;

        [FindsBy(How = How.ClassName, Using = "added-manually")]
        public IWebElement removeButton;

        public IReadOnlyCollection<IWebElement> UserGetsRemoveButtonsList(IWebDriver driver)
        {
            var list = driver.FindElements(By.ClassName("added-manually"));
            return list;
        }
    }
}
