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
        private static WindowsElement element;

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

        public static bool IsElementPresentAndDisplay(By locator)
        {
            try
            {
                element = Browser._Driver.FindElement(locator);
                if (element.Displayed == true)
                {
                    return true;
                }
                return false;
            }
            catch (WebDriverException)
            {
                return false;
            }
        }

        public static bool IsLoaderDisplay()
        {
            try
            {
                element = Browser._Driver.FindElementByAccessibilityId("Loader"); ;
                while (element.Displayed == true)
                {
                    WaitUntil.WaitSomeInterval(1);
                }
                return false;
            }
            catch (WebDriverException)
            {
                return false;
            }
        }

        public static bool IsMessageBoxDisplay()
        {
            try
            {
                element = Browser._Driver.FindElementByAccessibilityId("Messagebox"); ;
                while (element.Displayed == false)
                {
                    WaitUntil.WaitSomeInterval(1);
                }
                return true;
            }
            catch (WebDriverException)
            {
                return false;
            }
        }
    }
}
