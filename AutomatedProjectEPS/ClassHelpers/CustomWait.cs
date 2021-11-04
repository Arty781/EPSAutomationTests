using OpenQA.Selenium;
using System;
using System.Collections.Generic;
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
                var element = ElementIfVisible(driver.FindElement(locator));
                try
                {
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
                var element = ElementIfVisible(driver.FindElement(locator));
                try
                {
                    if (element != null && element.Displayed)
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


       
    }
}
