﻿using AutomatedProjectEPS.ClassHelpers;
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
        public IWebElement tabHome => Browser._Driver.FindElement(_tabHome);
        public readonly By _tabHome = By.XPath("//*[contains(@AutomationId, 'tb_Home')]");

        public IWebElement tabAccessManagement => Browser._Driver.FindElement(_tabAccessManagement);
        public readonly By _tabAccessManagement = By.XPath("//*[contains(@AutomationId, 'tb_AccessManagement')]");

        public IWebElement tabBinarySearch => Browser._Driver.FindElement(_tabBinarySearch);
        public readonly By _tabBinarySearch = By.XPath("//*[contains(@AutomationId, 'tb_BinarySearch')]");

        public IWebElement tabBinaryUpload => Browser._Driver.FindElement(_tabBinaryUpload);
        public readonly By _tabBinaryUpload = By.XPath("//*[contains(@AutomationId, 'tb_BinaryUpload')]");

        public IWebElement tabFlashHistory => Browser._Driver.FindElement(_tabFlashHistory);
        public readonly By _tabFlashHistory = By.XPath("//*[contains(@AutomationId, 'tb_FlashHistory')]");

        public IWebElement tabLogout => Browser._Driver.FindElement(_tabLogout);
        public readonly By _tabLogout = By.XPath("//*[contains(@AutomationId, 'tb_Logout')]");


    }
}
