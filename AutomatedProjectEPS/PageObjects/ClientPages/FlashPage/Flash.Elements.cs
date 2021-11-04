using AutomatedProjectEPS.ClassHelpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class Flash
    {

        public IWebElement btnFlash => Browser._Driver.FindElement(_btnFlash);
        public readonly By _btnFlash = By.XPath("//*[contains(@AutomationId, 'FlashItBtn')]");

        public IWebElement infoComplete => Browser._Driver.FindElement(_infoComplete);
        public readonly By _infoComplete = By.XPath("//*[contains(@AutomationId, 'Complete')]");

        public IWebElement btnNewFlash => Browser._Driver.FindElement(_btnNewFlash);
        public readonly By _btnNewFlash = By.XPath("//*[contains(@AutomationId, 'NewFlashBtn')]");      // 034 - Redirects to new flash

        public IWebElement textboxResult => Browser._Driver.FindElement(_textboxResult);
        public readonly By _textboxResult = By.XPath("//*[contains(@AutomationId, 'TxtBoxResult')]");     // 034 - textbox with result


        public IWebElement logsResult => Browser._Driver.FindElement(_logsResult);
        public readonly By _logsResult = By.XPath("//*[contains(@AutomationId, 'ProcessInfoTb')]");   //CC - LogsResult

    }
}
