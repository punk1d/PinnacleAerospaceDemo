using PinnacleFrameworkExcercise.CucumberActions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PinnacleFrameworkExcercise.PageObjects;

namespace PinnacleFrameworkExcercise.Tests
{
    [TestClass]
    public class BasicAuthTest : Setup
    {
        HomeBasicAuthPageObject Home;
        InvalidAuthPageObject InvalidAuthPage;
        

        [TestMethod]
        [Description("User logs in using Admin credentials")]
        public void LoginUsingValidCredentials()
        {
            Home = new HomeBasicAuthPageObject(driver);
            Given.GetUrl("https://admin:admin@ss-testing-automated-exercise.herokuapp.com/basic_auth", driver);
            Assert.AreEqual("Congratulations! You must have the proper credentials.", Then.SuccessMessageIsVisibleInHomePage(Home.successMessage));
        }

        [TestMethod]
        [Description("User tries log in using invalid credentials")]
        public void LoginUsingInvalidCredentials()
        {
            InvalidAuthPageObject InvalidAuthPage = new InvalidAuthPageObject(driver);
            Given.AuthenthicationFails("https://ss-testing-automated-exercise.herokuapp.com/basic_auth", driver, "admin1", "admin1");
            Then.WaitForInvalidCredentialsMessage(driver);
            Assert.AreEqual("Not authorized", InvalidAuthPage.invalidAuthMessage.Text);
        }
    }
}
