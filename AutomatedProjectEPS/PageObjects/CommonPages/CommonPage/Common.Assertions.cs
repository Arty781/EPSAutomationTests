using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Steps;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class Common
    {
        [AllureStep("Make sure the removed binary '{0}' has status - 8")]
        public void VerifyRemovedBinary(string binaryName)
        {
            WaitUntil.WaitSomeInterval(4);
            Assert.AreEqual(new AppDbContext().GetBinaryStatus(binaryName), "8");
        }
    }
}
