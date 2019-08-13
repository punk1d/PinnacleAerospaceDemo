using PinnacleFrameworkExcercise.Helpers;
using OpenQA.Selenium;
using PinnacleFrameworkExcercise.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PinnacleFrameworkExcercise.CucumberActions
{
    class When : ActionsHelper
    {
        private static List<string> _list;
        private static DynamicContentPageObject _DynamicContentPage;

        internal static int UserAddsMultipleElements(IWebElement element, int times)
        {
            if (times > 0)
            {
                element.Click();
                return UserAddsMultipleElements(element, times - 1);
            }
            else return times;
        }

        internal static void UserMovesSliderToValue(IWebElement slider, double value, double actualSliderValue, IWebDriver driver)
        {
            double result;
            string direction = "";

            if (actualSliderValue < value)
            {
                result = value - actualSliderValue;
                direction = Keys.ArrowRight;
            }
            else
            {
                result = actualSliderValue - value;
                direction = Keys.ArrowLeft;
            }
            
            var step = double.Parse(slider.GetAttribute("step"));
            var times = result / step;

            for (int i = 1; i < times; i++)
                direction += direction;

            HandleSliderElement( Int32.Parse(times.ToString()), direction, slider, driver);
        }

        internal static void UserEntersTextToPromptAlert(string text, IWebDriver driver)
        {
            HandleJSAlertPrompt(text, driver);
        }

        internal static void UserAcceptsJsAlert(IWebDriver driver)
        {
            HandleJSAlertAcceptButton(driver);
        }

        internal static void UserScrollToBottom(IWebDriver driver, IWebElement footer)
        {
            ScrollToBottom(driver, footer);
        }

        internal static void UserTriesLogin(string userName, string passWord, IWebElement userBox, IWebElement passwordBox, IWebElement loginButton)
        {
            userBox.SendKeys(userName);
            passwordBox.SendKeys(passWord);
            loginButton.Click();
        }

        internal static void UserMovesMouseOutOfViewPort()
        {
            MouseMove(0, 0);
        }

        internal static void UserEntersFilePath(string filePath, IWebDriver driver)
        {
            System.Threading.Thread.Sleep(3000);
            HandleUploadWindow(filePath);
        }

        internal static void UserClicksOnButton(IWebElement button)
        {
            button.Click();
        }

        internal static int UserCountsDeleteButtons(IWebDriver driver)
        {
            AddRemovePageObject pageObject = new AddRemovePageObject(driver);
            var list = pageObject.UserGetsRemoveButtonsList(driver);
            return list.Count;
        }

        internal static List<string> UserRefreshPageUntilImagesAreDisplayed(IReadOnlyCollection<IWebElement> imageList, IWebDriver driver)
        {
            //imageList = 
            if (_list == null)
                _list = new List<string>();

            foreach (var image in imageList)
            {
                var src = image.GetAttribute("src");

                if (!_list.Contains(src) && src != "https://ss-testing-automated-exercise.herokuapp.com/img/forkme_right_green_007200.png")
                    _list.Add(image.GetAttribute("src"));
            }

            if (_list.Count == 5)
                return _list;
            PageRefresh(driver);
            _DynamicContentPage = new DynamicContentPageObject(driver);
            var aux = _DynamicContentPage.GetImageList();
            return (UserRefreshPageUntilImagesAreDisplayed(aux, driver));
        }

        internal static bool UserChecksUntilElementIsPresent(IWebElement galleryButton, IWebDriver driver)
        {
            if (IsDisplayed(galleryButton))
                return true;
            JustWaitSomeTime(driver, 3);
            PageRefresh(driver);
            return (UserChecksUntilElementIsPresent(galleryButton, driver));

        }

        internal static bool UserChecksUntilElementIsNoLongerPresent(IWebElement galleryButton, IWebDriver driver)
        {
            if (!IsDisplayed(galleryButton))
                return true;
            JustWaitSomeTime(driver, 3);
            PageRefresh(driver);
            return (UserChecksUntilElementIsPresent(galleryButton, driver));
        }

        internal static void UserRightClicksOnContextMenu(IWebElement contextBox, IWebDriver driver)
        {
           ContextClick(contextBox, driver);
        }

        internal static void CheckboxIsClicked(IWebElement checkbox)
        {
            checkbox.Click();
        }

        public static async Task <int> UserGetsTotalBrokenImages(IReadOnlyCollection<IWebElement> images)
        {
            return await RetrievedImageDisplayedCount(images);
        }

        internal static int UserRemovesMultipleDeleteButtons(IWebElement element, int times)
        {
            if (times > 0)
            {
                element.Click();
                return UserRemovesMultipleDeleteButtons(element, times - 1);
            }
            else return times;
        }

        internal static bool UserVerifiesThatElementsAreCompletelyRemoved(IWebElement deleteButtons)
        {
            return IsDisplayed(deleteButtons);
        }

        internal static void UserDragsElementAToB(IWebElement elementA, IWebElement elementB, IWebDriver driver)
        {
            HandleDragAndDrop(elementA, elementB, driver);
            JustWaitSomeTime(driver, 10);
        }
    }
}
