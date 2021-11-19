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
    class BaseClassClientECU : BaseClient
    {
        [SetUp]
        public void Initialize() => Browser.Initialize(AppsPuth.ClientOEM);

        [OneTimeSetUp]
        public void OneTimeSetUp() => OneTimeSetUpBase(ControllerName.ECU);


    }
}