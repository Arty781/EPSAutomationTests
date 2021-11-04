using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _034.Tests
{
    [TestFixture]
    [AllureNUnit]
    class BaseClassClient
    {
        public static Process process;

        [SetUp]
        public void Initialize() => Browser.Initialize(AppsPuth.Client034);

        [OneTimeSetUp]
        public static void OneTimeSetUp() => process = Process.Start(Browser.RootPath() + DriverPuth.WinDriverPuth);


        [OneTimeTearDown]
        public static void OneTimeTearDown() => process.Kill();

        [TearDown]
        public static void TearDown() => Browser.Close();



    }
}
