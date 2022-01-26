using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Steps;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class Management
    {
        [AllureStep("Verify that User {0} is displayed in tree")]
        public void VerifyCreatedUser(string userNameLabel, string FirstName, string LastName)
        {
            WaitUntil.InvisibilityOfElementLocated(Pages.Common._Loader);
            Assert.AreEqual(Browser._Driver.FindElementByXPath("//*[contains(@Name, 'Jane')]").Text, FirstName + " " + LastName + " - " + userNameLabel);
        }

        [AllureStep("Verify that User {0} is not displayed in tree")]
        public void VerifyDeleteUser(string userNameLabel)
        {
            WaitUntil.InvisibilityOfElementLocated(Pages.Common._Loader);
            Assert.AreEqual(false, PresenceOfElement.IsElementPresent(By.Name(userNameLabel)));
        }

        [AllureStep("Verify that Dealer {0} is displayed in tree")]
        public void VerifyCreatedDealer(string dealerNameLabel)
        {
            WaitUntil.InvisibilityOfElementLocated(Pages.Common._Loader);
            Assert.AreEqual(Browser._Driver.FindElementByXPath("//*[contains(@Name, 'Jane')]").Text, dealerNameLabel);
        }

        [AllureStep("Verify that Dealer {0} is displayed in tree")]
        public void VerifyCreatedRootDealer(string dealerNameLabel)
        {
            WaitUntil.InvisibilityOfElementLocated(Pages.Common._Loader);
            Assert.AreEqual(Browser._Driver.FindElementByXPath("//*[contains(@Name, 'TestCompany')]").Text, dealerNameLabel);
        }

        [AllureStep("Verify that Dealer {0} is displayed in tree")]
        public void VerifyEditedDealer(string dealerNameLabel)
        {
            WaitUntil.InvisibilityOfElementLocated(Pages.Common._Loader);
            Assert.AreEqual(Browser._Driver.FindElementByXPath("//*[contains(@Name, 'Jane')]").Text, dealerNameLabel);
        }

        [AllureStep("Verify that \"User has been added\" pop-up is displayed")]
        public void VerifyUserSavedPopUp()
        {
            
            Assert.AreEqual(Pages.Common.Messagebox.Text, "User has been added");
        }

        [AllureStep("Verify that \"User has been edited\" pop-up is displayed")]
        public void VerifyUserEditedPopUp()
        {
            WaitUntil.InvisibilityOfElementLocated(Pages.Common._Loader);
            Assert.AreEqual(Pages.Common.Messagebox.Text, "User has been edited");
        }

        [AllureStep("Verify Confirmation pop-up is displayed")]
        public void VerifyDeletedConfirmationPopUp()
        {
            WaitUntil.InvisibilityOfElementLocated(Pages.Common._Loader);
            Assert.AreEqual(Pages.Common.Messagebox.Text, "Are you sure you want to delete this user?");
        }

        [AllureStep("Verify deleted User {0} pop-up is displayed")]
        public void VerifyDeletedUserPopUp(string userNameLabel)
        {
           
            Assert.AreEqual(Pages.Common.Messagebox.Text, "User "+ userNameLabel +" was deleted successfully");
        }

        [AllureStep("Verify deleted User {0} pop-up is displayed")]
        public void VerifyIsEditedUser(string userNameLabel)
        {
            WaitUntil.InvisibilityOfElementLocated(Pages.Common._Loader);
            Assert.AreEqual(Pages.Common.Messagebox.Text, "User " + userNameLabel + " was deleted successfully");
        }

        [AllureStep("Verify edited firstname is displayed")]
        public void VerifyUserEdited(string firstName)
        {
            WaitUntil.InvisibilityOfElementLocated(Pages.Common._Loader);
            Assert.AreEqual(firstName, Pages.Management.firstNameFld.Text);
        }

        [AllureStep("Verify flash limit is active and the number of flash limit is displayed")]
        public void VerifyIsActiveFlashLimit()
        {
            WaitUntil.InvisibilityOfElementLocated(Pages.Common._Loader);
            Assert.IsTrue(flashCountFld.Displayed);
            Assert.AreEqual(flashCountFld.Text, "1");
        }

        [AllureStep("Verify flash limit is edited")]
        public void VerifyIsEditedFlashLimit()
        {
            WaitUntil.InvisibilityOfElementLocated(Pages.Common._Loader);

            Assert.AreEqual("99998", flashCountFld.Text);
        }

        public bool CheckFilterData()
        {

            Pages.Common.SwitchWindow();
            List<string> givenList = new List<string>();
            List<string> filteredList = new List<string>();
            List<IWebElement> list = new List<IWebElement>(Browser._Driver.FindElements(By.XPath("//*/List[@AutomationId=\"EcusList\"]/ListItem")));
            foreach (var l in list)
            {

                givenList.Add(l.Text);

            }
            List<IWebElement> list1 = new List<IWebElement>(Browser._Driver.FindElements(By.XPath("//*/List[@AutomationId=\"EcusList\"]/ListItem")));
            foreach (var listItem in list1)
            {
                filteredList.Add(listItem.Text);
            }
            var firstList = givenList.Except(filteredList).ToString();
            var secondList = filteredList.Except(givenList).ToString();
            

            return !firstList.Any() && !secondList.Any();
        }
    }
}
