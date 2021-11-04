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
    public partial class BinaryUpload
    {
        [AllureStep("Upload base binary - {0}")]
        public BinaryUpload SelectBaseBinary(string puthBinary)
        {

            WaitUntil.ElementIsClickable(_btnBaseBinary);
            //Browser._Driver.FindElementById("tb_PerfomanceBinaries").Click();
            // btnBaseBinary.SendKeys(Browser.RootPath() + "Binariki\\" + puthBinary);
            string puth = "C:\\Users\\User\\source\\repos\\AutomatedProjectEPS\\Binariki\\Simos 084 - 8K0907551C S0005.bin";
            btnBaseBinary.SendKeys(puth + Keys.Enter);
            //CruciatusFactory.Keyboard.SendEnter();

            return this;
        }


        [AllureStep("Upload performance binary - {0}")]
        public BinaryUpload SelectPerformanceBinary(string puthBinary)
        {
            WaitUntil.ElementIsClickable(_btnPerformanceBinary);
            btnPerformanceBinary.SendKeys(Browser.RootPath() + "Binariki\\" + puthBinary);
            //CruciatusFactory.Keyboard.SendEnter();

            return this;
        }


        [AllureStep("Change binary label")]
        public BinaryUpload ChangeBinaryLabel()
        {
            WaitUntil.ElementIsClickable(_inputBinaryLabel);
            inputBinaryLabel.SendKeys(inputBinaryLabel.Text + " testqa-" + Browser.Random.Next(1, 10000000));
            return this;
        }

        [AllureStep("Select price from the list")]
        public BinaryUpload SelectPrice()
        {
            WaitUntil.ElementIsClickable(_comboBoxPricing);
            comboBoxPricing.SendKeys("final test");
            //comboBoxPricing.Click();
            WaitUntil.WaitSomeInterval(1);

            return this;
        }

        [AllureStep("Press the Upload button")]
        public BinaryUpload UploadBinary()
        {
            WaitUntil.WaitSomeInterval(1);
            WaitUntil.ElementIsClickable(_btnUploadBinary);
            btnUploadBinary.Click();
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
            // WaitUntil.WaitSomeInterval(1);
            return this;
        }
    }
}
