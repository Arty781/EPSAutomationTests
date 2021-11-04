using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class Flash
    {
        [AllureStep("Start the flashing vehicle")]
        public Flash PressFlashButton()
        {
            WaitUntil.ElementIsClickable(_btnFlash);
            btnFlash.Click();

            return this;
        }

        [AllureStep("Press NewFlash button")]
        public Flash PressNewFlashButton()
        {
            WaitUntil.ElementIsClickable(_btnNewFlash);
            btnNewFlash.Click();

            return this;
        }
    }
}
