using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.ClassHelpers
{
    [TestFixture]
    [AllureNUnit]
    public class BaseClient
    {
        private static WindowsDriver<WindowsElement> windowsDriver;
        public static Process process;
        
        public static void OneTimeSetUpBase(string controller)
        {
            process = Process.Start(Browser.RootPath() + DriverPuth.WinDriverPuth);

            AppiumOptions options = new AppiumOptions();
            options.AddAdditionalCapability("app", Lazarus.AppLazarus);
            options.AddAdditionalCapability("appWorkingDir", Browser.RootPath() + Lazarus.FolderName);
            windowsDriver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), options);
            Assert.NotNull(windowsDriver);
            new LazarusApp(windowsDriver).InitController(controller);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            windowsDriver?.Dispose();
            process?.Kill();  
        }

        [TearDown]
        public static void TearDown() => Browser.Close();




    }
}
