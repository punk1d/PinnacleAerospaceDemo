using PinnacleFrameworkExcercise.CucumberActions;
using PinnacleFrameworkExcercise.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PinnacleFrameworkExcercise.Tests
{
    [TestClass]
    public class FormAuthenticationTest : Setup
    {
        FormAuthenticacionPageObject login;
        FormAuthenticationHomePageObject home;

        [TestMethod]
        public void ValidateFormAuthentivation()
        {
            login = new FormAuthenticacionPageObject(driver);
            home = new FormAuthenticationHomePageObject(driver);
            Given.GetUrl("https://ss-testing-automated-exercise.herokuapp.com/login", driver);
            When.UserTriesLogin("tomsmith", "SuperSecretPassword!", login.userBox, login.passwordBox, login.LoginButton);
            var logInMessage = Then.messageIsDisplayed("You logged into a secure area!", home.message);
            When.UserClicksOnButton(home.logOutButton);
            login = new FormAuthenticacionPageObject(driver);
            var logOutMessage = Then.messageIsDisplayed("You logged out of the secure area!", login.invalidMessage);
            When.UserTriesLogin("tomsmith1", "SuperSecretPassword!", login.userBox, login.passwordBox, login.LoginButton);
            var invalidUserMessage = Then.messageIsDisplayed("Your username is invalid!", login.invalidMessage);
            When.UserTriesLogin("tomsmith", "SuperS1ecretPassword!", login.userBox, login.passwordBox, login.LoginButton);
            var invalidPasswordMessage = Then.messageIsDisplayed("Your password is invalid!", login.invalidMessage);
            Assert.AreEqual(new bool[] { true, true, true, true }, new bool[] { logInMessage, logOutMessage, invalidUserMessage, invalidPasswordMessage });
        }
    }
}
