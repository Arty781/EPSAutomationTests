using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.ClassHelpers
{
    public class CustomWait
    {
        private static IWebElement ElementIfVisible(IWebElement element)
        {
            return element.Displayed ? element : null;
        }
        public static Func<IWebDriver, IWebElement> CustomElementIsClickableByLocator(By locator)
        {
            return (driver) =>
            {
                try
                {
                    IWebElement element = ElementIfVisible(driver.FindElement(locator));
                    if (element != null && element.Enabled)
                    {
                        return element;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (StaleElementReferenceException)
                {
                    return null;
                }
            };
        }


        public static Func<IWebDriver, IWebElement> CustomElementIsVisibleByLocator(By locator)
        {
            return (driver) =>
            {
                try
                {
                    IWebElement element = ElementIfVisible(driver.FindElement(locator));
                    if (element != null)
                    {
                        return element;
                    }
                    else
                        return null;
                   
                    
                }
                catch (StaleElementReferenceException)
                {
                    return null;
                }
            };
        }


       
    }
}
