using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class BinarySearch
    {
        [AllureStep("Search the binary - {0}")]
        public BinarySearch SearchBinary(string binaryName)
        {
            WaitUntil.WaitSomeInterval(1);
            WaitUntil.ElementIsVisible(_inputSearch);
            inputSearch.SendKeys(binaryName);
            btnSearch.Click();

            return this;
        }

        [AllureStep("Press the found binary")]
        public BinarySearch SelectBinary()
        {
            WaitUntil.WaitSomeInterval();
            WaitUntil.ElementIsClickable(_listBoxItem);
            listBoxItem.Click();
            WaitUntil.ElementIsVisible(_infoCalibrations);
            return this;
        }

        [AllureStep("Press the EditBinary button")]
        public BinaryUpload PressEditBinaryButton()
        {
            WaitUntil.ElementIsClickable(_btnEdit);
            btnEdit.Click();

            return Pages.BinaryUpload;
        }

        [AllureStep("Press the RemoveBinary button")]
        public BinarySearch PressRemoveBinaryButton()
        {
            WaitUntil.ElementIsClickable(_btnRemove);
            btnRemove.Click();
            return this;
        }
    }
}
