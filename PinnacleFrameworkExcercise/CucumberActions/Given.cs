using System;
using System.Threading;
using OpenQA.Selenium;
using PinnacleFrameworkExcercise.Helpers;

namespace PinnacleFrameworkExcercise.CucumberActions
{
    public class Given : ActionsHelper
    {
        internal static void UserEntersPage(string url, IWebDriver driver)
        {
            GetUrl(url, driver);
        }

        internal static void AuthenthicationFails(string url, IWebDriver driver, string username, string password)
        {
            HandleChromeAuthWindow(username, password);
            GetUrl(url, driver);
        }

        internal static void UserCreatesAFile(string path)
        {
            createNewFile(path);
        }
    }
}
