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
            /*WaitUntil.WaitSecondWindowHandle(700);
            SwitchWindow();*/

            WaitUntil.VisibilityOfAllElementsLocatedBy(_progressBarBox, 900);
            progressBarBox.Click();
            progressBarBox.SendKeys(Keys.Enter);
            return this;
        }

        [AllureStep("Close message box")]
        public Common CloseProgressBar()
        {
            
            WaitUntil.VisibilityOfAllElementsLocatedBy(_progressBarBox, 30);
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
            
            WaitUntil.VisibilityOfAllElementsLocatedBy(_MessageBox, 120);
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

        [AllureStep("Wait until loader is closed")]
        public Common LoaderIsClosed()
        {
            WaitUntil.InvisibilityOfElementLocated(Pages.Common._Loader);
            return this;
        }



    }
}
