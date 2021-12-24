using AutomatedProjectEPS.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.ClassHelpers
{
    public class PresenceOfElement
    {
        public static bool IsElementPresent(By locator)
        {
            try
            {
                Browser._Driver.FindElement(locator);

                return true;
            }
            catch (WebDriverException)
            {
                return false;
            }
        }

    }
}
