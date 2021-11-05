using AutomatedProjectEPS.ClassHelpers;
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

        public IWebElement btnBaseBinary => Browser._Driver.FindElement(_btnBaseBinary);
        public readonly By _btnBaseBinary = By.XPath("//*[contains(@AutomationId, 'BrowseBaseBinaryBtn')]");

        public IWebElement btnPerformanceBinary => Browser._Driver.FindElement(_btnPerformanceBinary);
        public readonly By _btnPerformanceBinary = By.XPath("//*[contains(@AutomationId, 'BrowsePerformanceBinaryBtn')]");

        public IWebElement comboBoxPricing => Browser._Driver.FindElement(_comboBoxPricing);
        public readonly By _comboBoxPricing = By.XPath("//*[contains(@AutomationId, 'PricingCategoryCbbx')]");

        public IWebElement btnUploadBinary => Browser._Driver.FindElement(_btnUploadBinary);
        public readonly By _btnUploadBinary = By.XPath("//*[contains(@AutomationId, 'UploadBinaryBtn')]");

        public IWebElement btnAdd => Browser._Driver.FindElement(_btnAdd);
        public readonly By _btnAdd = By.XPath("//*[contains(@AutomationId, 'AddPerformanceBinaryBtn')]");

        public IWebElement inputBinaryLabel => Browser._Driver.FindElement(_inputBinaryLabel);
        public readonly By _inputBinaryLabel = By.XPath("//*[contains(@AutomationId, 'BinaryLabelTbx')]");

        public IWebElement btnEdit => Browser._Driver.FindElement(_btnEdit);
        public readonly By _btnEdit = By.XPath("//*[contains(@AutomationId, 'EditBinaryBtn')]");





    }
}
