using PinnacleFrameworkExcercise.CucumberActions;
using PinnacleFrameworkExcercise.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PinnacleFrameworkExcercise.Tests
{
    [TestClass]
    public class JSAlertsTests : Setup
    {
        JSAlertsPageObject page;

        [TestMethod]
        public void VerifyJSAlertsFeature()
        {
            page = new JSAlertsPageObject(driver);
            Given.GetUrl("https://ss-testing-automated-exercise.herokuapp.com/javascript_alerts", driver);
            When.UserClicksOnButton(page.JsAlertButton);
            When.UserAcceptsJsAlert(driver);
            var result =  Then.USerVerifiesTextInElement("You successfuly clicked an alert", page.messageText);
            When.UserClicksOnButton(page.JsPromptButton);
            When.UserEntersTextToPromptAlert("testing", driver);
            page = new JSAlertsPageObject(driver);
            Assert.AreEqual(result, Then.USerVerifiesTextInElement("You entered: testing", page.messageText));
        }
    }
}
