using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class Navigation
    {
        [AllureStep("Navigate to Home page")]
        public Home GoToHome()
        {
            WaitUntil.ElementIsClickable(_tabHome);
            tabHome.Click();
            return Pages.Home;
        }

        [AllureStep("Navigate to Access Management page")]
        public Management GoToAccessManagement()
        {
            WaitUntil.ElementIsClickable(_tabAccessManagement);
            tabAccessManagement.Click();
            return Pages.Management;
        }

        [AllureStep("Navigate to Binary Search page")]
        public BinarySearch GoToBinarySearch()
        {
            WaitUntil.WaitSomeInterval();
            WaitUntil.ElementIsClickable(_tabBinarySearch);
            tabBinarySearch.Click();
            return Pages.BinarySearch;
        }

        [AllureStep("Navigate to Binary Upload page")]
        public BinaryUpload GoToBinaryUpload()
        {
            WaitUntil.WaitSomeInterval();
            // WaitUntil.ElementIsClickable(tabBinaryUpload);
            tabBinaryUpload.Click();
            return Pages.BinaryUpload;
        }

        [AllureStep("Navigate to Flash History page")]
        public History GoToFlashHistory()
        {
            WaitUntil.ElementIsClickable(_tabFlashHistory);
            tabFlashHistory.Click();
            return Pages.History;
        }
    }
}
