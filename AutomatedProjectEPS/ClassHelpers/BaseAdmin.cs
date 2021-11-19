using NUnit.Allure.Core;
using NUnit.Framework;
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
    public class BaseAdmin
    {
        public static Process process;

        [OneTimeSetUp]
        public static void OneTimeSetUp() => process = Process.Start(Browser.RootPath() + DriverPuth.WinDriverPuth);


        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            if (process != null)
            {
                process.Kill();
            }
        }

        [TearDown]
        public static void TearDown()
        {
            if (Browser._Driver != null)
            {
                Browser.Close();
            }
        } 
    }
}

