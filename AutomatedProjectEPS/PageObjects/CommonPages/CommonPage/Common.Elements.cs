using AutomatedProjectEPS.ClassHelpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class Common
    {
        
        public IWebElement progressBarBox => Browser._Driver.FindElement(_progressBarBox);
        public readonly By _progressBarBox = By.XPath("//*[contains(@AutomationId, 'ProgressBarBox')]");

        public IWebElement btnNext => Browser._Driver.FindElement(_btnNext);
        public readonly By _btnNext = By.XPath("//*[contains(@AutomationId, 'NextBtn')]");

        public IWebElement btnPrevious => Browser._Driver.FindElement(_btnPrevious);
        public readonly By _btnPrevious = By.XPath("//*[contains(@AutomationId, 'btn_Previous')]");

        public IWebElement MessageBox => Browser._Driver.FindElement(_MessageBox);
        public readonly By _MessageBox = By.XPath("//*[contains(@AutomationId, 'MessageBox')]");

        public IWebElement Messagebox => Browser._Driver.FindElement(_Messagebox);
        public readonly By _Messagebox = By.XPath("//*[contains(@AutomationId, 'Messagebox')]");

        public IWebElement Loader => Browser._Driver.FindElement(_Loader);
        public readonly By _Loader = By.XPath("//*[contains(@AutomationId, 'Loader')]");




    }
}
