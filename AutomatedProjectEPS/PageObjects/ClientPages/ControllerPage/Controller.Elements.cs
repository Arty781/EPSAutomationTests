using AutomatedProjectEPS.ClassHelpers;
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
        public IWebElement btnEngine => Browser._Driver.FindElement(_btnEngine);
        public readonly By _btnEngine = By.XPath("//*[contains(@AutomationId, 'EngineECUBtn')]");

        public IWebElement btnTransmission => Browser._Driver.FindElement(_btnTransmission);
        public readonly By _btnTransmission = By.XPath("//*[contains(@AutomationId, 'TransmissionTCUBtn')]");



        public IWebElement btnCheckController => Browser._Driver.FindElement(_btnCheckController);
        public readonly By _btnCheckController = By.XPath("//*[contains(@AutomationId, 'ClickToIdControllerBtn')]");

        public IWebElement textboxControllerInfo => Browser._Driver.FindElement(_textboxControllerInfo);
        public readonly By _textboxControllerInfo = By.XPath("//*[contains(@AutomationId, 'ControllerInformationTbx')]");


    }
}
