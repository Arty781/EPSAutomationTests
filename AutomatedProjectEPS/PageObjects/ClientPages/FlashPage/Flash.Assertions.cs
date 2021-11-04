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
        public Flash CheckSuccessFlashing()
        {
            WaitUntil.ElementIsClickable(_btnNewFlash, 400);
            Browser._Driver.GetScreenshot();
            Assert.AreEqual(textboxResult.Text, "SuccessfulBurn");
            return this;
        }

        [AllureStep("Make sure the binary is installed successfully")]
        public Flash CheckSuccessFlashingLogs()
        {
            WaitUntil.ElementIsClickable(Pages.Calibration._btnConfirmEcuInformation);
            Assert.AreEqual(logsResult.Text.Substring(2, 23), "Programming completed");
            return this;
        }
    }
}
