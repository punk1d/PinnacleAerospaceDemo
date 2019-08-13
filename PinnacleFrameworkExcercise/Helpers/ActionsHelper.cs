using OpenQA.Selenium;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using AutoIt;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.IO;
using System.Text;

namespace PinnacleFrameworkExcercise.Helpers
{
    public class ActionsHelper : Setup
    {
        private static IAlert _alert;
        private static Actions _action;

        internal static void GetUrl(string url, IWebDriver driver)
        {
            driver.Url = url;
        }

        internal static void PageRefresh(IWebDriver driver)
        {
            driver.Navigate().Refresh();

        }

        internal static bool IsDisplayed(IWebElement element)
        {
            try
            {
                var aux = element.Displayed;
                return aux;
            }
            catch { return false; }
        }

        internal static async Task<int> RetrievedImageDisplayedCount(IReadOnlyCollection<IWebElement> images)
        {
            var httpClientHelper = new HttpClientHelper();
            var total = 0;
            foreach (IWebElement image in images)
            {
                HttpStatusCode code = await httpClientHelper.getStatusCodeFromHttpCall(image.GetAttribute("src"));
                if (code == HttpStatusCode.OK)
                    total++;
            }
            return total;
        }

        internal static string GetElementText(IWebElement element)
        {
            return element.Text;
        }

        internal static void HandleChromeAuthWindow(string username, string password)
        {
            new Thread(() =>
            {
                Thread.Sleep(500);
                AutoItX.WinActivate("Acceder", "https://ss-testing-automated-exercise.herokuapp.com");
                AutoItX.Send(@"" + username + "{TAB}" + password + "{ENTER}");
                Thread.Sleep(1000);
                AutoItX.Send("{TAB}{TAB}{TAB}");
                Thread.Sleep(1000);
                AutoItX.Send("{ENTER}");
            }).Start();
        }

        internal static void JustWaitSomeTime(IWebDriver driver, int seconds)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);
        }

        internal static void WaitForElementToBePresent(IWebDriver driver, string xPath, int seconds)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(xPath)));
        }

        internal static void ContextClick(IWebElement element, IWebDriver driver)
        {
            _action = new Actions(driver);
            _action.ContextClick(element).Build().Perform();
        }

        internal static string GetMessageFromAlert(IWebDriver driver)
        {
            _alert = driver.SwitchTo().Alert();
            var message = _alert.Text;
            return message;
        }

        public void DismissAlert(IWebDriver driver)
        {
            _alert = driver.SwitchTo().Alert();
            _alert.Dismiss();
        }

        public static void AlertOkClick(IWebDriver driver)
        {
            _alert = driver.SwitchTo().Alert();
            _alert.Accept();
        }

        internal static bool IsAlertDialogPresent(IWebDriver driver)
        {
            _alert = SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent().Invoke(driver);
            if (_alert == null)
                return false;
            return true;
        }

        internal static void HandleDragAndDrop(IWebElement sourceLocator, IWebElement destinationLocator, IWebDriver driver)
        {
            _action = new Actions(driver);
            var dest = destinationLocator.Location;
            AutoItX.MouseMove(150, 250, -1);
            AutoItX.MouseDown("LEFT");
            AutoItX.MouseMove(250, 250, -1);
            AutoItX.MouseUp();

            //_action.Click(sourceLocator)
            //    .MoveByOffset(0, 0)
            //    .ClickAndHold()
            //    .MoveByOffset(250,0)
            //    .Release()
            //    .Build().Perform();
            //_action.DragAndDrop(sourceLocator, destinatinationLocator);
            //_action.MoveToElement(destinatinationLocator).Build().Perform();
            //_action.Release();
        }


        internal static void MouseMove(int x, int y)
        {
            AutoItX.MouseMove(x, y);
        }

        internal static void createNewFile(string path)
        {
            try
            {
                if (File.Exists(path))
                    File.Delete(path);

                using (FileStream fs = File.Create(path))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("testing");
                    fs.Write(info, 0, info.Length);
                }                
            }catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        internal static void HandleUploadWindow(string filePath)
        { 
            AutoItX.Send(filePath);
            AutoItX.Send("{ENTER}");
        }

        internal static void ScrollToBottom(IWebDriver driver, IWebElement footer)
        {
            _action = new Actions(driver);
            _action.MoveToElement(footer).Perform();
        }

        internal static void HandleSliderElement(int times, string direction, IWebElement slider, IWebDriver driver)
        {
            _action = new Actions(driver);
            _action.Click().Perform();
            _action.SendKeys(slider, direction).Perform();
        }

        internal static void HandleJSAlertAcceptButton(IWebDriver driver)
        {
            _alert = driver.SwitchTo().Alert();
            _alert.Accept();
        }

        internal static void HandleJSAlertPrompt(string text, IWebDriver driver)
        {
            _alert = driver.SwitchTo().Alert();
            _alert.SendKeys(text);
            _alert.Accept();
        }
    }
}
