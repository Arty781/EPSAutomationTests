using AutomatedProjectEPS.ClassHelpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class BinarySearch
    {
        public IWebElement inputSearch => Browser._Driver.FindElement(_inputSearch);
        public readonly By _inputSearch = By.XPath("//*[contains(@AutomationId, 'SearchTbx')]");

        public IWebElement btnSearch => Browser._Driver.FindElement(_btnSearch);
        public readonly By _btnSearch = By.XPath("//*[contains(@AutomationId, 'SearchBtn')]");

        public IWebElement listBoxItem => Browser._Driver.FindElement(_listBoxItem);
        public readonly By _listBoxItem = By.XPath("//*[contains(@ClassName, 'ListBoxItem')]");   //class or id

        public IWebElement elemFromList => Browser._Driver.FindElement(_elemFromList);
        public readonly By _elemFromList = By.XPath("//*[contains(@AutomationId, 'EcuNameTb')]");   // Found elements

        public IWebElement infoCalibrations => Browser._Driver.FindElement(_infoCalibrations);
        public readonly By _infoCalibrations = By.XPath("//*[contains(@AutomationId, 'Calibrations')]");

        public IWebElement btnRemove => Browser._Driver.FindElement(_btnRemove);
        public readonly By _btnRemove = By.XPath("//*[contains(@AutomationId, 'RemoveBinaryBtn')]");

        public IWebElement btnEdit => Browser._Driver.FindElement(_btnEdit);
        public readonly By _btnEdit = By.XPath("//*[contains(@AutomationId, 'EditBinaryBtn')]");



    }
}
