using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.ClassHelpers
{
    class AllureServe
    {
        [Test]
        public void GoToAllureResults()
        {

            Process.Start(Browser.RootPath() + "allure serve.bat");
        }
    }
}
