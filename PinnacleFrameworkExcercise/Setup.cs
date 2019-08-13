using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace PinnacleFrameworkExcercise
{
    [TestClass]
    public class Setup
    {
        public IWebDriver driver;

        [TestInitialize]
        public void TestsSetup()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("headless");
            options.AddUserProfilePreference("disable-popup-blocking", "true");
            options.AddArgument("no-sandbox");
            driver = new FirefoxDriver(FirefoxDriverService.CreateDefaultService());
            //new ChromeDriver(ChromeDriverService.CreateDefaultService());
            driver.Manage().Window.Size = new Size(800, 600);
        }

        [TestCleanup]
        public void Cleanup()
        {    
            driver.Close();
        }
    }
}
