using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Steps;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class Calibration
    {
        [AllureStep("Press the Calibrate button")]
        public Calibration PressCalibrateButton()
        {
            WaitUntil.ElementIsClickable(_btnCalibrate);
            btnCalibrate.Click();

            return this;
        }

        [AllureStep("Select binary from the list - {0}")]
        public Calibration SelectBinaryJHM034()
        {
            WaitUntil.InvisibilityOfElementLocated(Pages.Common._Loader);
            cbbxBinaries.Click();
            WaitUntil.ElementIsVisible(_SelectedBinaryTb, 15);
            IReadOnlyCollection<IWebElement> ucuList = Browser._Driver.FindElementsByAccessibilityId("SelectedBinaryTb");
            foreach(var binary in ucuList)
            {
                if (binary.Displayed == true && binary.Text != "You must select a tune to continue")
                {
                    binary.Click();
                    break;
                }
                new Actions(Browser._Driver)
                    .SendKeys(Keys.ArrowDown)
                    .Build()
                    .Perform();
            }
            
            return this;
        }


        [AllureStep("Select calibration for selected binary - {0}")]
        public Calibration SelectCalibrationJHM034(string calibration)
        {
            WaitUntil.InvisibilityOfElementLocated(Pages.Common._Loader);
            cbbxCalibrations.Click();
            cbbxCalibrations.FindElement(By.Name(calibration)).Click();
            return this;
        }

        [AllureStep("Select binary from the list - {0}")]
        public Calibration SelectBinary()
        {
            WaitUntil.ElementIsVisible(_cbbxBinaries, 30);
            cbbxBinaries.Click();
            WaitUntil.ElementIsVisible(_SelectedBinaryTb, 15);
            IReadOnlyCollection<IWebElement> ucuList = Browser._Driver.FindElementsByAccessibilityId("SelectedBinaryTb");
            foreach (var binary in ucuList)
            {
                if (binary.Displayed == true && binary.Text != "You must select a tune to continue")
                {
                    binary.Click();
                    break;
                }
                new Actions(Browser._Driver)
                    .SendKeys(Keys.ArrowDown)
                    .Build()
                    .Perform();
            }

            return this;
        }


        [AllureStep("Select calibration for selected binary - {0}")]
        public Calibration SelectCalibration(string calibration)
        {
            WaitUntil.ElementIsVisible(_cbbxCalibrations, 30);
            cbbxCalibrations.Click();
            cbbxCalibrations.FindElement(By.Name(calibration)).Click();
            return this;
        }

        [AllureStep("Press Confirm button for binary information")]
        public Calibration PressConfirmButtonForBinaryInfo()
        {
            WaitUntil.ElementIsVisible(_btnConfirmEcuInformation);
            btnConfirmEcuInformation.Click();
            return this;
        }

        [AllureStep("Select binary from the list - {0}")]
        public Calibration SelectBinaryOEM()
        {
            WaitUntil.ElementIsVisible(_lbEcus);
            
            IReadOnlyCollection<IWebElement> ucuList = Browser._Driver.FindElementsByAccessibilityId("EcusLb");
            foreach (var binary in ucuList)
            {
                if (binary.Displayed == true && binary.Text != "You must select a tune to continue")
                {
                    binary.Click();
                    break;
                }
                new Actions(Browser._Driver)
                    .SendKeys(Keys.ArrowDown)
                    .Build()
                    .Perform();
            }

            return this;
        }

        [AllureStep("Select calibration for selected binary - {0}")]
        public Calibration SelectCalibrationOEM(string calibration)
        {
            /*WaitUntil.InvisibilityOfElementLocated(Pages.Common._Loader);*/
            lbCalibrations.FindElement(By.Name(calibration)).Click();
            return this;
        }

    }
}
