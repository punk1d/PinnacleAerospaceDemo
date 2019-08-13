using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PinnacleFrameworkExcercise.PageObjects
{
    class FormAuthenticacionPageObject
    {
        private readonly IWebDriver _driver;

        public FormAuthenticacionPageObject(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        [FindsBy(How = How.Id, Using = "username")]
        public IWebElement userBox;

        [FindsBy(How = How.Id, Using = "password")]
        public IWebElement passwordBox;

        [FindsBy(How = How.CssSelector, Using = "html.no-js body div.row div#content.large-12.columns div.example form#login button.radius i.fa.fa-2x.fa-sign-in")]
        public IWebElement LoginButton;

        [FindsBy(How = How.Id, Using = "flash")]
        public IWebElement invalidMessage;
    }
}
