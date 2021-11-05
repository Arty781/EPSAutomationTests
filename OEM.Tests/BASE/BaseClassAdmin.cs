using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Diagnostics;


namespace OEM.Tests
{
    [TestFixture]
    [AllureNUnit]
    class BaseClassAdmin
    {
        public static Process process;

        [SetUp]
        public void Initialize() => Browser.Initialize(AppsPuth.AdminOEM);

        [OneTimeSetUp]
        public static void OneTimeSetUp() => process = Process.Start(Browser.RootPath() + DriverPuth.WinDriverPuth);


        [OneTimeTearDown]
        public static void OneTimeTearDown() => process.Kill();

        [TearDown]
        public static void TearDown() => Browser.Close();
    }
}
