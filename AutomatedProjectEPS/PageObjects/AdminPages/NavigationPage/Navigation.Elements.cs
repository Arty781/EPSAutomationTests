using AutomatedProjectEPS.ClassHelpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class Navigation
    {
        public IWebElement tabHome => Browser._Driver.FindElementByAccessibilityId("HomeTb");
        public readonly By _tabHome = By.XPath("//*[contains(@AutomationId, 'HomeTb')]");

        public IWebElement tabAccessManagement => Browser._Driver.FindElementByAccessibilityId("AccessManagementTb");
        public readonly By _tabAccessManagement = By.XPath("//*[contains(@AutomationId, 'AccessManagementTb')]");

        public IWebElement tabBinarySearch => Browser._Driver.FindElementByAccessibilityId("BinarySearchTb");
        public readonly By _tabBinarySearch = By.XPath("//*[contains(@AutomationId, 'BinarySearchTb')]");

        public IWebElement tabBinaryUpload => Browser._Driver.FindElementByAccessibilityId("BinaryUploadTb");
        public readonly By _tabBinaryUpload = By.XPath("//*[contains(@AutomationId, 'BinaryUploadTb')]");

        public IWebElement tabFlashHistory => Browser._Driver.FindElementByAccessibilityId("FlashHistoryTb");
        public readonly By _tabFlashHistory = By.XPath("//*[contains(@AutomationId, 'FlashHistoryTb')]");

        public IWebElement tabLogout => Browser._Driver.FindElementByAccessibilityId("LogoutTb");
        public readonly By _tabLogout = By.XPath("//*[contains(@AutomationId, 'LogoutTb')]");


    }
}
