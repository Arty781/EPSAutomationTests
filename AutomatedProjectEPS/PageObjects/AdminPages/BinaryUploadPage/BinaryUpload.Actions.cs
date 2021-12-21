using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Steps;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class BinaryUpload
    {
        [AllureStep("Upload base binary - {0}")]
        public BinaryUpload SelectBaseBinary(string puthBinary)
        {
            WaitUntil.ElementIsClickable(_btnBaseBinary);
            Browser._Driver.FindElementByAccessibilityId("PerfomanceBinariesTb").Click();
            btnBaseBinary.SendKeys(Keys.Enter + Browser.RootPath() + "Binariki\\" + puthBinary + Keys.Enter);
            return this;
        }


        [AllureStep("Upload performance binary - {0}")]
        public BinaryUpload SelectPerformanceBinary(string puthBinary)
        {
            WaitUntil.ElementIsClickable(_btnPerformanceBinary);
            btnPerformanceBinary.SendKeys(Keys.Enter + Browser.RootPath() + "Binariki\\" + puthBinary + Keys.Enter);
            return this;
        }

        #region beforeRefactoring
        [AllureStep("Upload performance binary - {0}")]
        public BinaryUpload BrowsePerformanceBinary(string puthBinary)
        {
            IWebElement btnBrowse = Browser._Driver.FindElementByAccessibilityId("BrowsePerformanceBinaryBtn");
            WaitUntil.ElementIsClickable(By.XPath("//*[contains(@AutomationId, 'BrowsePerformanceBinaryBtn')]"));
            btnBrowse.SendKeys(Keys.Enter + Browser.RootPath() + "Binariki\\" + puthBinary + Keys.Enter);
            return this;
        }
        public BinaryUpload PressAddPerfButton()
        {
            IWebElement btnAdd = Browser._Driver.FindElementByAccessibilityId("AddPerformanceBinaryBtn");
            WaitUntil.ElementIsClickable(By.XPath("//*[contains(@AutomationId, 'AddPerformanceBinaryBtn')]"));
            btnAdd.Click();
            return this;
        }

        #endregion






        [AllureStep("Change binary label")]
        public BinaryUpload ChangeBinaryLabel(string filter)
        {
            WaitUntil.ElementIsClickable(_inputBinaryLabel);
            string label = GetBinaryLabel();
            inputBinaryLabel.Clear();
            inputBinaryLabel.SendKeys(label + " " + filter + "QA-TEST" + " " + DateTime.Now);
            return this;
        }




        [AllureStep("Select price from the list")]
        public BinaryUpload SelectPrice()
        {
            WaitUntil.ElementIsClickable(_comboBoxPricing);
            //comboBoxPricing.SendKeys("Testing");
            comboBoxPricing.SendKeys(Keys.Down);
            WaitUntil.WaitSomeInterval(1);

            return this;
        }

        [AllureStep("Press the Upload button")]
        public BinaryUpload UploadBinary()
        {
            WaitUntil.ElementIsClickable(_btnUploadBinary);
            btnUploadBinary.Click();
            return this;

        }

        [AllureStep("Press the Edit button")]
        public BinaryUpload EditBinary()
        {
            WaitUntil.ElementIsClickable(_btnEdit);
            btnEdit.Click();
            return this;

        }

        [AllureStep("Press the Add button")]
        public BinaryUpload PressAddButton()
        {
            WaitUntil.ElementIsClickable(_btnAdd);
            btnAdd.Click();
            return this;
        }

        [AllureStep("Press the Edit button")]
        public BinaryUpload PressEditButton()
        {
            WaitUntil.ElementIsClickable(_btnEdit);
            btnEdit.Click();
            return this;
        }

        [AllureStep("Get binary label")]
        public string GetBinaryLabel()
        {
            string label = inputBinaryLabel.Text;
            return label;
        }

        public BinaryUpload ScrollDown()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Control + Keys.End)
                .Build()
                .Perform();
            WaitUntil.WaitSomeInterval(1);
            return this;
        }
    }
}
