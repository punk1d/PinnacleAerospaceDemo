using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PinnacleFrameworkExcercise.PageObjects
{
    class FormAuthenticationHomePageObject
    {
        private readonly IWebDriver _driver;

        public FormAuthenticationHomePageObject(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "html.no-js body div.row div#content.large-12.columns div.example a.button.secondary.radius")]
        public IWebElement logOutButton;

        [FindsBy(How = How.Id, Using = "flash")]
        public IWebElement message;
    }
}
