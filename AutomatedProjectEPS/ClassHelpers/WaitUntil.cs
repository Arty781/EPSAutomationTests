using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading.Tasks;


namespace AutomatedProjectEPS.ClassHelpers
{
    class WaitUntil
    {
        public static void WaitSomeInterval(int seconds = 2) => 
            Task.Delay(TimeSpan.FromSeconds(seconds)).Wait();

        public static void ElementIsVisible(By locator, int seconds = 10) =>
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds)).Until(CustomWait.CustomElementIsVisibleByLocator(locator));
        
        public static void ElementIsClickable(By locator, int seconds = 10) =>
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds)).Until(CustomWait.CustomElementIsClickableByLocator(locator));

        public static void WaitSecondWindowHandle(int seconds = 10) =>
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds)).Until(d => d.WindowHandles.Count > 1);

        public static void WaitDriverLoad(int seconds = 10) =>
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds)).Until(d => d.WindowHandles.Count > 1);

        public static void VisibilityOfAllElementsLocatedBy(By locator, int seconds = 10)
        {
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.VisibilityOfAllElementsLocatedBy(locator));
            new WebDriverWait(Browser._Driver, TimeSpan.FromSeconds(seconds)).Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }



    }
}
