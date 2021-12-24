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
            WaitUntil.InvisibilityOfLoader();
            Assert.AreEqual(Browser._Driver.FindElementByXPath("//*[contains(@Name, 'Jane')]").Text, FirstName + " " + LastName + " - " + userNameLabel);
        }

        [AllureStep("Verify that User {0} is not displayed in tree")]
        public void VerifyDeleteUser(string userNameLabel)
        {
            WaitUntil.InvisibilityOfLoader();
            Assert.AreEqual(false, PresenceOfElement.IsElementPresent(By.Name(userNameLabel)));
        }

        [AllureStep("Verify that Dealer {0} is displayed in tree")]
        public void VerifyCreatedDealer(string dealerNameLabel)
        {
            WaitUntil.InvisibilityOfLoader();
            Assert.AreEqual(Browser._Driver.FindElementByXPath("//*[contains(@Name, 'Jane QA')]").Text, dealerNameLabel);
        }
    }
}
