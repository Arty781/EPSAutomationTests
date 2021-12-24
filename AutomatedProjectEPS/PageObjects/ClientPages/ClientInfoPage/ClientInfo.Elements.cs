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


        //Only OEM
        public IWebElement inputHouse => Browser._Driver.FindElementByAccessibilityId("AdressSecondTbx");


        //Commom button
        public IWebElement btnConfirmCustomerInfo => Browser._Driver.FindElementByAccessibilityId("ConfirmCustomerInfoBtn");
        public readonly By _btnConfirmCustomerInfo = By.XPath("//*[contains(@AutomationId, 'ConfirmCustomerInfoBtn')]");



        //VWR, SRT, CC
        public IWebElement inputFirstNameVWR => Browser._Driver.FindElement(_inputFirstNameVWR);
        public readonly By _inputFirstNameVWR = By.XPath("//*[contains(@AutomationId, 'FirstNameCtr')]/*[contains(@ClassName, 'TextBox')]");

        public IWebElement inputLastNameVWR => Browser._Driver.FindElementByXPath("//*[contains(@AutomationId, 'SecondNameCtr')]/*[contains(@ClassName, 'TextBox')]");
        public readonly By _inputLastNameVWR = By.XPath("//*[contains(@AutomationId, 'SecondNameCtr')]/*[contains(@ClassName, 'TextBox')]");
        public IWebElement inputAddressVWR => Browser._Driver.FindElementByXPath("//*[contains(@AutomationId, 'StreetCtr')]/*[contains(@ClassName, 'TextBox')]");
        public readonly By _inputAddressVWR = By.XPath("//*[contains(@AutomationId, 'StreetCtr')]/*[contains(@ClassName, 'TextBox')]");
        public IWebElement inputCityVWR => Browser._Driver.FindElementByXPath("//*[contains(@AutomationId, 'CityCtr')]/*[contains(@ClassName, 'TextBox')]");
        public readonly By _inputCityVWR = By.XPath("//*[contains(@AutomationId, 'CityCtr')]/*[contains(@ClassName, 'TextBox')]");
        public IWebElement inputStateVWR => Browser._Driver.FindElementByXPath("//*[contains(@AutomationId, 'StateCtr')]/*[contains(@ClassName, 'TextBox')]");
        public readonly By _inputStateVWR = By.XPath("//*[contains(@AutomationId, 'StateCtr')]/*[contains(@ClassName, 'TextBox')]");
        public IWebElement inputZIPVWR => Browser._Driver.FindElementByXPath("//*[contains(@AutomationId, 'PostCodeCtr')]/*[contains(@ClassName, 'TextBox')]");
        public readonly By _inputZIPVWR = By.XPath("//*[contains(@AutomationId, 'PostCodeCtr')]/*[contains(@ClassName, 'TextBox')]");
        public IWebElement cbbxCountryVWR => Browser._Driver.FindElementByXPath("//*[contains(@AutomationId, 'CountriesCbx')]");
        public readonly By _cbbxCountryVWR = By.XPath("//*[contains(@AutomationId, 'CountriesCbx')]");
        public IWebElement inputEmailVWR => Browser._Driver.FindElementByXPath("//*[contains(@AutomationId, 'EmailCtr')]/*[contains(@ClassName, 'TextBox')]");
        public readonly By _inputEmailVWR = By.XPath("//*[contains(@AutomationId, 'EmailCtr')]/*[contains(@ClassName, 'TextBox')]");
        public IWebElement inputPhoneVWR => Browser._Driver.FindElementByXPath("//*[contains(@AutomationId, 'PhoneCtr')]/*[contains(@ClassName, 'TextBox')]");
        public readonly By _inputPhoneVWR = By.XPath("//*[contains(@AutomationId, 'PhoneCtr')]/*[contains(@ClassName, 'TextBox')]");
        public IWebElement inputNoteVWR => Browser._Driver.FindElementByXPath("//*[contains(@AutomationId, 'HouseCtr')]/*[contains(@ClassName, 'TextBox')]");
        public readonly By _inputNoteVWR = By.XPath("//*[contains(@AutomationId, 'HouseCtr')]/*[contains(@ClassName, 'TextBox')]");
    }
}
