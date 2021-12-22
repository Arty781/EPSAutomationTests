using AutomatedProjectEPS.ClassHelpers;
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
        public void VerifyCreatedUser(string userNameLabel, string FirstName, string LastName)
        {
            WaitUntil.WaitSomeInterval(1);
            Assert.AreEqual(Browser._Driver.FindElementByXPath("//*[contains(@Name, 'Jane')]").Text, FirstName + " " + LastName + " - " + userNameLabel);
        }

        public void VerifyDeleteUser(string userNameLabel)
        {
            WaitUntil.WaitSomeInterval(1);
            Assert.AreEqual(false, PresenceOfElement.IsElementPresent(By.Name(userNameLabel)));
        }
    }
}
