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
    public partial class History
    {
        [AllureStep("Change Start Date")]
        public History ChangeStartDate()
        {
            WaitUntil.WaitSomeInterval(3);
            WaitUntil.ElementIsVisible(_datePicker);
            datePicker.Clear();
            datePicker.SendKeys(DateTime.Today.ToString("dd.MM.yy"));

            return this;
        }

        [AllureStep("Select Distributor")]
        public History SelectDistributor(string distributorName)
        {
            
            WaitUntil.ElementIsClickable(_cbbxDistributor);
            cbbxDistributor.Click();
            WaitUntil.ElementIsVisible(By.Name(distributorName));
            cbbxDistributor.FindElement(By.Name(distributorName)).Click();

            return this;
        }

        [AllureStep("Press 'Get Report' button")]
        public History PressGetReportButton()
        {
            WaitUntil.ElementIsClickable(_btnGetReport);
            btnGetReport.Click();
            
            return this;
        }
    }
}
