using AutomatedProjectEPS.ClassHelpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class Management
    {
        #region Create User locators
        public IWebElement ExpanderBtn => Browser._Driver.FindElementByAccessibilityId("Expander");
        public readonly By _ExpanderBtn = By.XPath("//Window[contains(@Name, 'Admin App')]//*[contains(@AutomationId, 'Expander')]");
        public IWebElement AddUserBtn => Browser._Driver.FindElementByAccessibilityId("AddUserBtn");
        public readonly By _addUserBtn = By.XPath("//Window[contains(@Name, 'Admin App')]//*[contains(@AutomationId, 'AddUserBtn')]");
        public IWebElement firstNameFld => Browser._Driver.FindElementByAccessibilityId("UserFirstNameTbx");
        public readonly By _firstNameFld = By.XPath("//*[contains(@AutomationId, 'UserFirstNameTbx')]");
        public IWebElement lastNameFld => Browser._Driver.FindElementByAccessibilityId("UserLastNameTbx");
        public readonly By _lastNameFld = By.XPath("//*[contains(@AutomationId, 'UserLastNameTbx')]");
        public IWebElement emailFld => Browser._Driver.FindElementByAccessibilityId("EmailTbx");
        public readonly By _emailFld = By.XPath("//*[contains(@AutomationId, 'EmailTbx')]");
        public IWebElement phoneFld => Browser._Driver.FindElementByAccessibilityId("PhoneTbx");
        public readonly By _phoneFld = By.XPath("//*[contains(@AutomationId, 'PhoneTbx')]");
        public IWebElement faxFld => Browser._Driver.FindElementByAccessibilityId("FaxTbx");
        public readonly By _faxFld = By.XPath("//*[contains(@AutomationId, 'FaxTbx')]");
        public IWebElement addressFld => Browser._Driver.FindElementByAccessibilityId("Address1Tbx");
        public readonly By _addressFld = By.XPath("//*[contains(@AutomationId, 'Address1Tbx')]");
        public IWebElement cityFld => Browser._Driver.FindElementByAccessibilityId("CityTbx");
        public readonly By _cityFld = By.XPath("//*[contains(@AutomationId, 'CityTbx')]");
        public IWebElement zipFld => Browser._Driver.FindElementByAccessibilityId("ZipCodeTbx");
        public readonly By _zipFld = By.XPath("//*[contains(@AutomationId, 'ZipCodeTbx')]");
        public IWebElement countryCbbx => Browser._Driver.FindElementByAccessibilityId("CountryCbbx");
        public readonly By _countryCbbx = By.XPath("//Window[contains(@Name, 'Admin App')]//*[contains(@AutomationId, 'CountryCbbx')]");
        public IWebElement roleCbbx => Browser._Driver.FindElementByAccessibilityId("RoleCbbx");
        public readonly By _roleCbbx = By.XPath("//Window[contains(@Name, 'Admin App')]//*[contains(@AutomationId, 'RoleCbbx')]");
        public IWebElement accStatusBtn => Browser._Driver.FindElementByAccessibilityId("AccountStatusTbtn");
        public readonly By _accStatusBtn = By.XPath("//Window[contains(@Name, 'Admin App')]//*[contains(@AutomationId, 'AccountStatusTbtn')]");
        public IWebElement accNotesBtn => Browser._Driver.FindElementByAccessibilityId("EditNotesBtn");
        public readonly By _accNotesBtn = By.XPath("//Window[contains(@Name, 'Admin App')]//*[contains(@AutomationId, 'EditNotesBtn')]");
        public IWebElement flashCountBtn => Browser._Driver.FindElementByAccessibilityId("FlashCountSwitcherTbtn");
        public readonly By _flashCountBtn = By.XPath("//*[contains(@AutomationId, 'FlashCountSwitcherTbtn')]");
        public IWebElement flashCountFld => Browser._Driver.FindElementByAccessibilityId("FlashCountValueTbx");
        public readonly By _flashCountFld = By.XPath("//*[contains(@AutomationId, 'FlashCountValueTbx')]");
        public IWebElement flashIncreaseLimitBtn => Browser._Driver.FindElementByAccessibilityId("IncreaseLimitBtn");
        public readonly By _flashIncreaseLimitBtn = By.XPath("//*[contains(@AutomationId, 'IncreaseLimitBtn')]");
        public IWebElement flashDecreaseLimitBtn => Browser._Driver.FindElementByAccessibilityId("DecreaseLimitBtn");
        public readonly By _flashDecreaseLimitBtn = By.XPath("//*[contains(@AutomationId, 'DecreaseLimitBtn')]");
        public IWebElement filterFld => Browser._Driver.FindElementByAccessibilityId("CalibrationFilterTbx");
        public readonly By _filterFld = By.XPath("//*[contains(@AutomationId, 'CalibrationFilterTbx')]");
        public IWebElement filterDescrFld => Browser._Driver.FindElementByAccessibilityId("DescriptionFilterTbx");
        public readonly By _filterDescrFld = By.XPath("//*[contains(@AutomationId, 'DescriptionFilterTbx')]");
        public IWebElement andRadioBtn => Browser._Driver.FindElementByAccessibilityId("AndOperationRbtn");
        public readonly By _andRadioBtn = By.XPath("//*[contains(@AutomationId, 'AndOperationRbtn')]");
        public IWebElement orRadioBtn => Browser._Driver.FindElementByAccessibilityId("OrOperationRbtn");
        public readonly By _orRadioBtn = By.XPath("//*[contains(@AutomationId, 'OrOperationRbtn')]");
        public IWebElement addFilterBtn => Browser._Driver.FindElementByAccessibilityId("AddFilterBtn");
        public readonly By _addFilterBtn = By.XPath("//*[contains(@AutomationId, 'AddFilterBtn')]");
        public IWebElement testAllFilterBtn => Browser._Driver.FindElementByAccessibilityId("TestAllFiltersBtn");
        public readonly By _testAllFilterBtn = By.XPath("//*[contains(@AutomationId, 'TestAllFiltersBtn')]");
        public IWebElement testFilterBtn => Browser._Driver.FindElementByAccessibilityId("TestFilterBtn");
        public readonly By _testFilterBtn = By.XPath("//*[contains(@AutomationId, 'TestFilterBtn')]");
        public IWebElement removeFilterBtn => Browser._Driver.FindElementByAccessibilityId("RemoveFilterBtn");
        public readonly By _removeFilterBtn = By.XPath("//*[contains(@AutomationId, 'RemoveFilterBtn')]");
        public IWebElement usernameFld => Browser._Driver.FindElementByAccessibilityId("UserNameTbx");
        public readonly By _usernameFld = By.XPath("//Window[contains(@Name, 'Admin App')]//*[contains(@AutomationId, 'UserNameTbx')]");
        public IWebElement userPasswordFld => Browser._Driver.FindElementByAccessibilityId("UserPasswordPbx");
        public readonly By _userPasswordFld = By.XPath("//*[contains(@AutomationId, 'UserPasswordPbx')]");
        public IWebElement saveUserBtn => Browser._Driver.FindElementByAccessibilityId("SaveUserBtn");
        public readonly By _saveUserBtn = By.XPath("//Window[contains(@Name, 'Admin App')]//*[contains(@AutomationId, 'SaveUserBtn')]");
        public IWebElement clickToScroll => Browser._Driver.FindElementByAccessibilityId("Image");
        public readonly By _clickToScroll = By.XPath("//*[contains(@ClassName, 'Image')]");
        public IWebElement refreshBtn => Browser._Driver.FindElementByAccessibilityId("RefreshActivityLogBtn");
        public readonly By _refreshBtn = By.XPath("//*[contains(@ClassName, 'RefreshActivityLogBtn')]");

        #endregion
        #region Edit user locators
        public IWebElement searchFld => Browser._Driver.FindElementByAccessibilityId("SearchTextTbx");
        public readonly By _searchFld = By.XPath("//Window[contains(@Name, 'Admin App')]//*[contains(@AutomationId, 'SearchTextTbx')]");
        /*locators for CC, SRT, VWR, OEM browsers*/
        public IWebElement searchBtn => Browser._Driver.FindElement(_searchBtn);
        public readonly By _searchBtn = By.XPath("//*[contains(@Name, 'SEARCH')]");
        /*locators for 034, JHM browsers*/
        public IWebElement searchBtn034 => Browser._Driver.FindElementByAccessibilityId("SearchBtn");
        public readonly By _searchBtn034 = By.XPath("//*[@AutomationId='SearchBtn']");

        public IWebElement userConfPasswordFld => Browser._Driver.FindElementByAccessibilityId("ConfirmPasswordPbx");
        public readonly By _userConfPasswordFld = By.XPath("*[contains(@AutomationId, 'ConfirmPasswordPbx')]");
        public IWebElement userDeleteBtn => Browser._Driver.FindElementByAccessibilityId("DeleteUserBtn");
        public readonly By _userDeleteBtn = By.XPath("//*[contains(@AutomationId, 'DeleteUserBtn')]");

        public IWebElement treeItemBtn => Browser._Driver.FindElementByAccessibilityId("TreeItemBtn");
        public readonly By _treeItemBtn = By.XPath("//*[contains(@AutomationId, 'TreeItemBtn')]");

        public IWebElement clickImg => Browser._Driver.FindElement(_clickImg);
        public readonly By _clickImg = By.XPath("//*[contains(@ClassName, 'Image')]");

        public IWebElement noteTextArea => Browser._Driver.FindElement(_noteTextArea);
        public readonly By _noteTextArea = By.XPath("//Window[@AutomationId=\"Messagebox\"][@Name=\"Edit Note\"]/Edit[@ClassName=\"TextBox\"]");
        public IWebElement noteSaveBtn => Browser._Driver.FindElement(_noteSaveBtn);
        public readonly By _noteSaveBtn = By.XPath("//Window[@AutomationId=\"Messagebox\"][@Name=\"Edit Note\"]/Button[@Name=\"Save\"][@ClassName=\"Button\"]");

        #endregion
    }
}
