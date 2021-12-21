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
        public IWebElement ExpanderBtn => Browser._Driver.FindElement(_ExpanderBtn);
        public readonly By _ExpanderBtn = By.XPath("//*[contains(@AutomationId, 'Expander')]");
        public IWebElement AddUserBtn => Browser._Driver.FindElement(_addUserBtn);
        public readonly By _addUserBtn = By.XPath("//*[contains(@AutomationId, 'AddUserBtn')]");
        public IWebElement firstNameFld => Browser._Driver.FindElement(_firstNameFld);
        public readonly By _firstNameFld = By.XPath("//*[contains(@AutomationId, 'UserFirstNameTbx')]");
        public IWebElement lastNameFld => Browser._Driver.FindElement(_lastNameFld);
        public readonly By _lastNameFld = By.XPath("//*[contains(@AutomationId, 'UserLastNameTbx')]");
        public IWebElement emailFld => Browser._Driver.FindElement(_emailFld);
        public readonly By _emailFld = By.XPath("//*[contains(@AutomationId, 'EmailTbx')]");
        public IWebElement phoneFld => Browser._Driver.FindElement(_phoneFld);
        public readonly By _phoneFld = By.XPath("//*[contains(@AutomationId, 'PhoneTbx')]");
        public IWebElement faxFld => Browser._Driver.FindElement(_faxFld);
        public readonly By _faxFld = By.XPath("//*[contains(@AutomationId, 'FaxTbx')]");
        public IWebElement addressFld => Browser._Driver.FindElement(_addressFld);
        public readonly By _addressFld = By.XPath("//*[contains(@AutomationId, 'Address1Tbx')]");
        public IWebElement cityFld => Browser._Driver.FindElement(_cityFld);
        public readonly By _cityFld = By.XPath("//*[contains(@AutomationId, 'CityTbx')]");
        public IWebElement zipFld => Browser._Driver.FindElement(_zipFld);
        public readonly By _zipFld = By.XPath("//*[contains(@AutomationId, 'ZipCodeTbx')]");
        public IWebElement countryCbbx => Browser._Driver.FindElement(_countryCbbx);
        public readonly By _countryCbbx = By.XPath("//*[contains(@AutomationId, 'CountryCbbx')]");
        public IWebElement roleCbbx => Browser._Driver.FindElement(_roleCbbx);
        public readonly By _roleCbbx = By.XPath("//*[contains(@AutomationId, 'RoleCbbx')]");
        public IWebElement accStatusBtn => Browser._Driver.FindElement(_accStatusBtn);
        public readonly By _accStatusBtn = By.XPath("//*[contains(@AutomationId, 'AccountStatusTbtn')]");
        public IWebElement accNotesBtn => Browser._Driver.FindElement(_accNotesBtn);
        public readonly By _accNotesBtn = By.XPath("//*[contains(@AutomationId, 'EditNotesBtn')]");
        public IWebElement flashCountBtn => Browser._Driver.FindElement(_flashCountBtn);
        public readonly By _flashCountBtn = By.XPath("//*[contains(@AutomationId, 'FlashCountSwitcherTbtn')]");
        public IWebElement flashCountFld => Browser._Driver.FindElement(_flashCountFld);
        public readonly By _flashCountFld = By.XPath("//*[contains(@AutomationId, 'FlashCountValueTbx')]");
        public IWebElement flashIncreaseLimitBtn => Browser._Driver.FindElement(_flashIncreaseLimitBtn);
        public readonly By _flashIncreaseLimitBtn = By.XPath("//*[contains(@AutomationId, 'IncreaseLimitBtn')]");
        public IWebElement flashDecreaseLimitBtn => Browser._Driver.FindElement(_flashDecreaseLimitBtn);
        public readonly By _flashDecreaseLimitBtn = By.XPath("//*[contains(@AutomationId, 'DecreaseLimitBtn')]");
        public IWebElement filterFld => Browser._Driver.FindElement(_filterFld);
        public readonly By _filterFld = By.XPath("//*[contains(@AutomationId, 'CalibrationFilterTbx')]");
        public IWebElement filterDescrFld => Browser._Driver.FindElement(_filterDescrFld);
        public readonly By _filterDescrFld = By.XPath("//*[contains(@AutomationId, 'DescriptionFilterTbx')]");
        public IWebElement andRadioBtn => Browser._Driver.FindElement(_andRadioBtn);
        public readonly By _andRadioBtn = By.XPath("//*[contains(@AutomationId, 'AndOperationRbtn')]");
        public IWebElement orRadioBtn => Browser._Driver.FindElement(_orRadioBtn);
        public readonly By _orRadioBtn = By.XPath("//*[contains(@AutomationId, 'OrOperationRbtn')]");
        public IWebElement addFilterBtn => Browser._Driver.FindElement(_addFilterBtn);
        public readonly By _addFilterBtn = By.XPath("//*[contains(@AutomationId, 'AddFilterBtn')]");
        public IWebElement testAllFilterBtn => Browser._Driver.FindElement(_testAllFilterBtn);
        public readonly By _testAllFilterBtn = By.XPath("//*[contains(@AutomationId, 'TestAllFiltersBtn')]");
        public IWebElement testFilterBtn => Browser._Driver.FindElement(_testFilterBtn);
        public readonly By _testFilterBtn = By.XPath("//*[contains(@AutomationId, 'TestFilterBtn')]");
        public IWebElement removeFilterBtn => Browser._Driver.FindElement(_removeFilterBtn);
        public readonly By _removeFilterBtn = By.XPath("//*[contains(@AutomationId, 'RemoveFilterBtn')]");
        public IWebElement usernameFld => Browser._Driver.FindElement(_usernameFld);
        public readonly By _usernameFld = By.XPath("//*[contains(@AutomationId, 'UserNameTbx')]");
        public IWebElement userPasswordFld => Browser._Driver.FindElement(_userPasswordFld);
        public readonly By _userPasswordFld = By.XPath("//*[contains(@AutomationId, 'UserPasswordPbx')]");
        public IWebElement saveUserBtn => Browser._Driver.FindElement(_saveUserBtn);
        public readonly By _saveUserBtn = By.XPath("//*[contains(@AutomationId, 'SaveUserBtn')]");
        public IWebElement clickToScroll => Browser._Driver.FindElement(_clickToScroll);
        public readonly By _clickToScroll = By.XPath("//*[contains(@ClassName, 'Image')]");
        public IWebElement refreshBtn => Browser._Driver.FindElement(_refreshBtn);
        public readonly By _refreshBtn = By.XPath("//*[contains(@ClassName, 'RefreshActivityLogBtn')]");

        #endregion
        #region Edit user locators
        public IWebElement searchFld => Browser._Driver.FindElement(_searchFld);
        public readonly By _searchFld = By.XPath("//*[contains(@AutomationId, 'SearchTextTbx')]");
        /*locators for CC, SRT, VWR, OEM browsers*/
        public IWebElement searchBtn => Browser._Driver.FindElement(_searchBtn);
        public readonly By _searchBtn = By.XPath("//*[contains(@Name, 'SEARCH')]");
        /*locators for 034, JHM browsers*/
        public IWebElement searchBtn034 => Browser._Driver.FindElement(_searchBtn034);
        public readonly By _searchBtn034 = By.XPath("//*[@AutomationId='SearchBtn']");

        public IWebElement userConfPasswordFld => Browser._Driver.FindElement(_userConfPasswordFld);
        public readonly By _userConfPasswordFld = By.XPath("//*[contains(@AutomationId, 'ConfirmPasswordPbx')]");
        public IWebElement userDeleteBtn => Browser._Driver.FindElement(_userDeleteBtn);
        public readonly By _userDeleteBtn = By.XPath("//*[contains(@AutomationId, 'DeleteUserBtn')]");

        public IWebElement treeItemBtn => Browser._Driver.FindElement(_treeItemBtn);
        public readonly By _treeItemBtn = By.XPath("//*[contains(@AutomationId, 'TreeItemBtn')]");

        public IWebElement clickImg => Browser._Driver.FindElement(_clickImg);
        public readonly By _clickImg = By.XPath("//*[contains(@ClassName, 'Image')]");
        #endregion
    }
}
