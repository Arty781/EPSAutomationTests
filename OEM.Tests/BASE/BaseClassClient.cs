using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Core;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Diagnostics;

namespace OEM.Tests
{
    [TestFixture]
    [AllureNUnit]
    class BaseClassClient
    {
        public static Process process;

        [SetUp]
        public void Initialize() => Browser.Initialize(AppsPuth.ClientOEM);

       //[OneTimeSetUp]
       // public static void OneTimeSetUp() => process = Process.Start(Browser.RootPath() + DriverPuth.WinDriverPuth);


       // [OneTimeTearDown]
       // public static void OneTimeTearDown() => process.Kill();

        [TearDown]
        public static void TearDown() => Browser.Close();



    }
}