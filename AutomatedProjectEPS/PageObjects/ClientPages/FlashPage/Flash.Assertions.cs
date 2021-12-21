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
    public partial class Flash
    {
        [AllureStep("Make sure the binary is installed successfully")]
        public Flash CheckSuccessFlashing034()
        {
            WaitUntil.VisibilityOfAllElementsLocatedBy(_btnNewFlash, 600);
            Assert.AreEqual(textboxResult034.Text, "SuccessfulBurn");
            return this;
        }

        [AllureStep("Make sure the binary is installed successfully")]
        public Flash CheckSuccessFlashingJHM()
        {
            WaitUntil.VisibilityOfAllElementsLocatedBy(_btnNewFlash, 600);
            Assert.AreEqual(textboxResultJHM.Text, "SuccessfulBurn");
            return this;
        }

        [AllureStep("Make sure the binary is installed successfully")]
        public Flash CheckSuccessFlashingLogs()
        {
            WaitUntil.ElementIsClickable(Pages.Calibration._btnConfirmEcuInformation);
            Assert.AreEqual(logsResult.Text.Substring(2, 21), "Programming completed");
            return this;
        }
    }
}
