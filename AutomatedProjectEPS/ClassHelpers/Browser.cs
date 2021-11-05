using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("app", application);
            options.AddAdditionalCapability("deviceName", "WindowsPC");
          
            windowsDriver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), options);
            Assert.NotNull(windowsDriver);
            windowsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);

            

            


        }

        public static string RootPath()
        {
            string mainpath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..\\..\\..\\..\\"));
            return mainpath;
        }

        public static ISearchContext Driver { get { return windowsDriver; } }
        public static WindowsDriver<WindowsElement> _Driver { get { return windowsDriver; } }
        public static void Close() { windowsDriver.Close(); }
        public static Random Random { get { return new Random(); } }

        

       

    }
}
