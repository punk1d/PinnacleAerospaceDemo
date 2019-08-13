using PinnacleFrameworkExcercise.Helpers;
using OpenQA.Selenium;
using System.IO;

namespace PinnacleFrameworkExcercise.CucumberActions
{
    class Then : ActionsHelper
    {
        internal static string SuccessMessageIsVisibleInHomePage(IWebElement successMessage)
        {
            return GetElementText(successMessage);
        }

        internal static void WaitForInvalidCredentialsMessage(IWebDriver driver)
        {
            WaitForElementToBePresent(driver, "/html/body", 3);
        }

        internal static string VerifyCheckboxIsChecked(IWebElement checkbox)
        {
            return checkbox.GetAttribute("checked");
        }

        internal static bool VerifyMessageInAlert(string message, IWebDriver driver)
        {
            if (GetMessageFromAlert(driver) == message)
                return true;
            return false;                       
        }

        internal static bool USerVerifiesTextInElement(string expectedMessage, IWebElement messageText)
        {
            return messageText.Text == expectedMessage;
        }

        internal static bool messageIsDisplayed(string message, IWebElement page)
        {
            return message == page.Text;
        }

        internal static bool VerifyFileExists(string filename)
        {
            var userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\');
            if (File.Exists(@"C:\Users\" + userName[1] + @"\Downloads\" + filename))
                return true;
            return false;
        }

        internal static object UserVerifiesCheckboxMessage(IWebElement message)
        {
            IsDisplayed(message);
            if (message.Text == "It's gone!")
                return true;
            return false;
        }

        internal static bool UserVerifiesElementIsEnabled(IWebElement element)
        {
            return element.Enabled;
        }

        internal static bool UserVerifiesAIsNowInB(IWebElement columnA)
        {
            if (columnA.Text == "B")
                return true;
            return false;
                
        }

        internal static bool VerifyAlertIsClosed(IWebDriver driver)
        {
            AlertOkClick(driver);
            //DismissAlert(driver);
            if (!IsAlertDialogPresent(driver))
                return true;
            return false;
        }
    }
}
