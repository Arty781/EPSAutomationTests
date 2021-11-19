using AutomatedProjectEPS.ClassHelpers;
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
        public IWebElement datePicker => Browser._Driver.FindElement(_datePicker);
        public readonly By _datePicker = By.XPath("//*[contains(@AutomationId, 'StartDateDp')]");

        public IWebElement cbbxDistributor => Browser._Driver.FindElement(_cbbxDistributor);
        public readonly By _cbbxDistributor = By.XPath("//*[contains(@AutomationId, 'DistributorCbbx')]");

        public IWebElement btnGetReport => Browser._Driver.FindElement(_btnGetReport);
        public readonly By _btnGetReport = By.XPath("//*[contains(@AutomationId, 'GetReportBtn')]");
    }
}
