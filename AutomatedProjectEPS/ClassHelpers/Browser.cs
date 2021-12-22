using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using System;
using System.IO;


namespace AutomatedProjectEPS.ClassHelpers
{
    public class Browser
    {
        public WindowsDriver<WindowsElement> WindowsDriver { get; set; }
        private static WindowsDriver<WindowsElement> windowsDriver;


        public Browser(WindowsDriver<WindowsElement> windowsDriver)
        {
            WindowsDriver = windowsDriver;
        }

        public static void Initialize(string application)
        {
            AppiumOptions options = new();
            options.AddAdditionalCapability("app", application);
            options.AddAdditionalCapability("deviceName", "WindowsPC");
            options.AddAdditionalCapability("ms:waitForAppLaunch", 3);
            windowsDriver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), options);
            Assert.NotNull(windowsDriver);
            windowsDriver.Manage().Window.Maximize();
        }

        public static string RootPath()
        {
            string mainpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\"));
            return mainpath;
        }

        public static ISearchContext Driver { get { return windowsDriver; } }
        public static WindowsDriver<WindowsElement> _Driver { get { return windowsDriver; } }
        public static void Close() => windowsDriver?.Close();
        public static Random Random { get { return new Random(); } }


        /*public void SelectComboboxItem(AppiumWebElement element, int index)
        {
            while (element.Text == "Testing")
            {

            }




            element.Click();

            var comboBoxItems = element.FindElementByAccessibilityId
                ("ListBoxItem");

            //new Actions(element.WrappedDriver).MoveToElement(comboBoxItems[index]).Click().Perform();

        }*/


    }
}
