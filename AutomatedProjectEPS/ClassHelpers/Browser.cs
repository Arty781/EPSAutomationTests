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
        private static WindowsElement orphanedElement;
        private static string orphanedWindowHandle;

        ~Browser()
        {
            CleanupOrphanedSession();
        }

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
            windowsDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            List<string> AllContexts = new List<string>();
            foreach (var context in (Browser._Driver.Contexts))
            {
                AllContexts.Add(context);
            }
            

            /*var currentHandle = windowsDriver.CurrentWindowHandle;
            string test = windowsDriver.Title;
            var test1 = windowsDriver.SessionId;
            var test2 = windowsDriver.Contexts.*/
        }

        public static WindowsDriver<WindowsElement> CreateNewSession(string appId, string argument = null)
        {
            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("app", appId);
            options.AddAdditionalCapability("deviceName", "WindowsPC");

            if (argument != null)
            {
                options.AddAdditionalCapability("appArguments", argument);
            }

            return new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), options);
        }

        public static bool CurrentWindowIsAlive(WindowsDriver<WindowsElement> remoteSession)
        {
            bool windowIsAlive = false;

            if (remoteSession != null)
            {
                try
                {
                    windowIsAlive = !string.IsNullOrEmpty(remoteSession.CurrentWindowHandle) && remoteSession.CurrentWindowHandle != "0";
                    windowIsAlive = true;
                }
                catch { }
            }

            return windowIsAlive;
        }

        public static WindowsElement GetOrphanedElement()
        {
            // Re-initialize orphaned session and element if they are compromised
            if (windowsDriver == null || orphanedElement == null)
            {
                InitializeOrphanedSession();
            }

            return orphanedElement;
        }

        public static WindowsDriver<WindowsElement> GetOrphanedSession()
        {
            // Re-initialize orphaned session and element if they are compromised
            if (windowsDriver == null || orphanedElement == null || string.IsNullOrEmpty(orphanedWindowHandle))
            {
                InitializeOrphanedSession();
            }

            return windowsDriver;
        }


        public static string GetOrphanedWindowHandle()
        {
            // Re-initialize orphaned session and element if they are compromised
            if (windowsDriver == null || orphanedElement == null || string.IsNullOrEmpty(orphanedWindowHandle))
            {
                InitializeOrphanedSession();
            }

            return orphanedWindowHandle;
        }

        private static void CleanupOrphanedSession()
        {
            orphanedWindowHandle = null;
            orphanedElement = null;

            // Cleanup after the session if exists
            if (windowsDriver != null)
            {
                windowsDriver.Quit();
                windowsDriver = null;
            }
        }


        private static void InitializeOrphanedSession()
        {
            // Create new calculator session and close the window to get an orphaned element
            CleanupOrphanedSession();
            windowsDriver = CreateNewSession(AppsPuth.Client034);
            //orphanedElement = windowsDriver.FindCalculatorTitleByAccessibilityId();
            orphanedWindowHandle = windowsDriver.CurrentWindowHandle;
            windowsDriver.Close();
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
