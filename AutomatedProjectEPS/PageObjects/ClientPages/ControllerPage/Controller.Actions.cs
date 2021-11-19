using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Steps;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class Controller
    {

        [AllureStep("Press checkId button")]
        public Controller PressCheckIdButton()
        {
            WaitUntil.ElementIsClickable(_btnCheckController);
            btnCheckController.Click();

            return this;
        }

        [AllureStep("Select controller for Engine")]
        public Controller SelectEngineController()
        {
            WaitUntil.ElementIsClickable(_btnEngine);
            btnEngine.Click();

            return this;
        }

        [AllureStep("Select controller for Transmission")]
        public Controller SelectTransmissionController()
        {
            WaitUntil.VisibilityOfAllElementsLocatedBy(_btnTransmission);
            btnTransmission.Click();

            return this;
        }

        public string GetControllerInfo()
        {
            WaitUntil.ElementIsClickable(_btnCheckController, 50);

            string fullInfo = textboxControllerInfo.Text;
            string first = fullInfo.Substring(0, 11);
            string last = fullInfo.Substring(fullInfo.Length - 4);
            string info = first +" "+ last;
            return info;
            
        }
    }
}
