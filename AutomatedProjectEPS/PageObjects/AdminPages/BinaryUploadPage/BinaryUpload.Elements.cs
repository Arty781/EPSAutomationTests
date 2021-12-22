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

        public IWebElement btnBaseBinary => Browser._Driver.FindElementByAccessibilityId("BrowseBaseBinaryBtn");
        public readonly By _btnBaseBinary = By.XPath("//*[contains(@AutomationId, 'BrowseBaseBinaryBtn')]");

        public IWebElement btnPerformanceBinary => Browser._Driver.FindElementByAccessibilityId("BrowsePerformanceBinaryBtn");
        public readonly By _btnPerformanceBinary = By.XPath("//*[contains(@AutomationId, 'BrowsePerformanceBinaryBtn')]");


        public IWebElement comboBoxPricing => Browser._Driver.FindElementByAccessibilityId("PricingCategoryCbbx");
        public readonly By _comboBoxPricing = By.XPath("//*[contains(@AutomationId, 'PricingCategoryCbbx')]");

        public IWebElement btnUploadBinary => Browser._Driver.FindElementByAccessibilityId("UploadBinaryBtn");
        public readonly By _btnUploadBinary = By.XPath("//*[contains(@AutomationId, 'UploadBinaryBtn')]");

        public IWebElement btnAdd => Browser._Driver.FindElementByAccessibilityId("AddPerformanceBinaryBtn");
        public readonly By _btnAdd = By.XPath("//*[contains(@AutomationId, 'AddPerformanceBinaryBtn')]");

        public IWebElement inputBinaryLabel => Browser._Driver.FindElementByAccessibilityId("BinaryLabelTbx");
        public readonly By _inputBinaryLabel = By.XPath("//*[contains(@AutomationId, 'BinaryLabelTbx')]");

        public IWebElement btnEdit => Browser._Driver.FindElementByAccessibilityId("EditBinaryBtn");
        public readonly By _btnEdit = By.XPath("//*[contains(@AutomationId, 'EditBinaryBtn')]");





    }
}
