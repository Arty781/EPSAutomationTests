using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Diagnostics;

namespace SRT.Tests
{
    [TestFixture]
    [AllureNUnit]
    class BaseClassClient
    {
        public static Process process;

        [SetUp]
        public void Initialize() => Browser.Initialize(AppsPuth.ClientSRT);

        [OneTimeSetUp]
        public static void OneTimeSetUp() => process = Process.Start(Browser.RootPath() + DriverPuth.WinDriverPuth);


        [OneTimeTearDown]
        public static void OneTimeTearDown() => process.Kill();

        [TearDown]
        public static void TearDown() => Browser.Close();



    }
}