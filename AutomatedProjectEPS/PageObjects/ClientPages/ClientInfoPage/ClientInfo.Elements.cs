using AutomatedProjectEPS.ClassHelpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class ClientInfo
    {
        //OEM, 034, JHM
        public IWebElement inputFirstName => Browser._Driver.FindElement(_inputFirstName);
        public readonly By _inputFirstName = By.XPath("//*[contains(@AutomationId, 'FirstNameTbx')]");

        public IWebElement inputLastName => Browser._Driver.FindElementByAccessibilityId("LastNameTbx");
        public IWebElement inputAddress => Browser._Driver.FindElementByAccessibilityId("AddressTbx");
        public IWebElement inputCity => Browser._Driver.FindElementByAccessibilityId("FirstCityTbx");
        public IWebElement inputState => Browser._Driver.FindElementByAccessibilityId("StateTbx");
        public IWebElement inputZIP => Browser._Driver.FindElementByAccessibilityId("ZipTbx");
        public IWebElement cbbxCountry => Browser._Driver.FindElementByAccessibilityId("CountryCbx");
        public IWebElement inputEmail => Browser._Driver.FindElementByAccessibilityId("EmailTbx");
        public IWebElement inputPhone => Browser._Driver.FindElementByAccessibilityId("PhoneTbx");
        public IWebElement inputNote => Browser._Driver.FindElementByAccessibilityId("NotesTbx");


        //Commom button
        public IWebElement btnConfirmCustomerInfo => Browser._Driver.FindElement(_btnConfirmCustomerInfo);
        public readonly By _btnConfirmCustomerInfo = By.XPath("//*[contains(@AutomationId, 'ConfirmCustomerInfoBtn')]");



        //VWR, SRT, CC
        public IWebElement inputFirstNameVWR => Browser._Driver.FindElement(_inputFirstNameVWR);
        public readonly By _inputFirstNameVWR = By.XPath("//*[contains(@AutomationId, 'FirstNameCtr')]/*[contains(@ClassName, 'TextBox')]");

        public IWebElement inputLastNameVWR => Browser._Driver.FindElementByXPath("//*[contains(@AutomationId, 'LastNameCtr')]/*[contains(@ClassName, 'TextBox')]");
        public IWebElement inputAddressVWR => Browser._Driver.FindElementByXPath("//*[contains(@AutomationId, 'StreetCtr')]/*[contains(@ClassName, 'TextBox')]");
        public IWebElement inputCityVWR => Browser._Driver.FindElementByXPath("//*[contains(@AutomationId, 'CityCtr')]/*[contains(@ClassName, 'TextBox')]");
        public IWebElement inputStateVWR => Browser._Driver.FindElementByXPath("//*[contains(@AutomationId, 'StateCtr')]/*[contains(@ClassName, 'TextBox')]");
        public IWebElement inputZIPVWR => Browser._Driver.FindElementByXPath("//*[contains(@AutomationId, 'ZipCodeCtr')]/*[contains(@ClassName, 'TextBox')]");
        public IWebElement cbbxCountryVWR => Browser._Driver.FindElementByXPath("//*[contains(@AutomationId, 'CountriesCbbx')]");
        public IWebElement inputEmailVWR => Browser._Driver.FindElementByXPath("//*[contains(@AutomationId, 'EmailCtr')]/*[contains(@ClassName, 'TextBox')]");
        public IWebElement inputPhoneVWR => Browser._Driver.FindElementByXPath("//*[contains(@AutomationId, 'PhoneCtr')]/*[contains(@ClassName, 'TextBox')]");
        public IWebElement inputNoteVWR => Browser._Driver.FindElementByXPath("//*[contains(@AutomationId, 'HouseNumOrNameCtr')]/*[contains(@ClassName, 'TextBox')]");
    }
}
