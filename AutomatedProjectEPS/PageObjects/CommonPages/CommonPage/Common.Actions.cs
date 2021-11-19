using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Steps;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class Common
    {
       
        [AllureStep("Press next button")]
        public Common PressNextButton()
        {
            WaitUntil.ElementIsClickable(_btnNext, 40);
            WaitUntil.WaitSomeInterval(1);
            btnNext.Click();
            return this;
        }

        /*[AllureStep("Wait finish flashing")]
        public Common WaitFinishFlasingOEM()
        {
            WaitUntil.WaitSecondWindowHandle(600);
            SwitchWindow();
            return this;
        }

        [AllureStep("Wait finish flashing")]
        public Common WaitFinishFlasingOEM()
        {
            WaitUntil.WaitSecondWindowHandle(600);
            SwitchWindow();
            return this;
        }*/

        [AllureStep("Close message box")]
        public Common CloseProgressBarAfterFlashing()
        {
            WaitUntil.WaitSecondWindowHandle(600);
            SwitchWindow();

            WaitUntil.ElementIsVisible(_progressBarBox);
            progressBarBox.Click();
            progressBarBox.SendKeys(Keys.Enter);
            return this;
        }

        [AllureStep("Close message box")]
        public Common CloseProgressBar()
        {
            WaitUntil.WaitSecondWindowHandle();
            SwitchWindow();

            WaitUntil.ElementIsVisible(_progressBarBox);
            progressBarBox.Click();
            progressBarBox.SendKeys(Keys.Enter);
            return this;
        }

        [AllureStep("Close message box")]
        public Common PressEnterKey()
        {
            WaitUntil.VisibilityOfAllElementsLocatedBy(_Messagebox, 30);
            Messagebox.Click();
            Messagebox.SendKeys(Keys.Enter);
            return this;
        }


        [AllureStep("Close message box")]
        public Common CloseMessageBox()
        {
            WaitUntil.WaitSecondWindowHandle();
            SwitchWindow();

            WaitUntil.ElementIsVisible(_MessageBox);
            MessageBox.Click();
            MessageBox.SendKeys(Keys.Enter);

            return this;
        }

        [AllureStep("Wait fifteen seconds")]
        public Common WaitFifteenSeconds()
        {
            WaitUntil.WaitSomeInterval(16);
            return this;
        }

        public Common SwitchWindow()
        {
            WaitUntil.WaitSomeInterval();
            Browser._Driver.SwitchTo().Window(Browser._Driver.WindowHandles.ToList().First());
            return this;
        }

       

    }
}
