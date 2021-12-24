using AutomatedProjectEPS.ClassHelpers;
using AutomatedProjectEPS.PageObjects;
using NUnit.Allure.Steps;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class Common
    {
        [AllureStep("Make sure the removed binary '{0}' is not displayed")]
        public void VerifyRemovedBinary(string binaryName)
        {
            /*WaitUntil.WaitSomeInterval(4);
            Assert.AreEqual(new AppDbContext().GetBinaryStatus(binaryName), "8");*/

            WaitUntil.InvisibilityOfLoader();
            Assert.AreEqual(false, PresenceOfElement.IsElementPresent(By.Name(binaryName)));
        }

        [AllureStep("Make sure the User '{0}' created")]
        public void VerifyCreatedUser(string userName)
        {
            WaitUntil.WaitSomeInterval(1);
            Assert.AreEqual(new AppDbContext().GetLastUserName(userName), userName);
        }

        /*[AllureStep("Make sure the last added User with email '{0}' has status - 2")]
        public void VerifyDeleteUser(string userName, string userNameLabel)
        {
            WaitUntil.WaitSomeInterval(1);
            bool val = false;
            try
            {
                new WebDriverWait(Browser._Driver, new TimeSpan(0,0,10)).Until(ExpectedConditions.ElementExists(By.XPath("//*[contains(@Name, 'testautomation')]")));
                IReadOnlyCollection<IWebElement> treeItems = Browser._Driver.FindElements(By.XPath("//*[contains(@Name, 'testautomation')]"));

                foreach(var item in treeItems)

            }
            
            Pages.Management
             .SearchUser(userNameLabel);
            ;
            Assert.AreEqual(new AppDbContext().GetUserStatus(userName), "2");
        }*/
    }
}
