using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Steps;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
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

        [AllureStep("Search User 034/JHM")]
        public Management SearchUser034(string userName)
        {
            PresenceOfElement.IsLoaderDisplay();
            searchFld.SendKeys(userName);

            new Actions(Browser._Driver)
            .Click(searchBtn034)
            .Build()
            .Perform();


            return this;
        }

        [AllureStep("Search User")]
        public Management SearchUser(string userName)
        {
            searchFld.SendKeys(userName);
            PresenceOfElement.IsLoaderDisplay();
            new Actions(Browser._Driver)
            .Click(searchBtn034)
            .Build()
            .Perform();
            WaitUntil.VisibleAndClickable(_ExpanderBtn);


            return this;
        }

        [AllureStep("Open Users Tree")]
        public Management OpenTree()
        {
            PresenceOfElement.IsLoaderDisplay();
            WaitUntil.VisibleAndClickable(_ExpanderBtn);
            ExpanderBtn.Click();
            /*IWebElement userName = Browser._Driver.FindElementByXPath("//*[contains(@Name, 'testautomation')]");*/

            return this;
        }

        [AllureStep("Press \"Add User\" Button")]
        public Management PressAddUserBtn()
        {
            IReadOnlyCollection<IWebElement> addBtnCollection = Browser._Driver.FindElementsByAccessibilityId("AddUserBtn");
            foreach (var item in addBtnCollection)
            {
                if (item.Displayed == true)
                {
                    item.SendKeys(Keys.Control);
                    new Actions(Browser._Driver)
                        .Release(item)
                        .Build()
                        .Perform();
                    item.Click();
                }

            }

            return this;
        }


        [AllureStep("Enter the user First Name")]
        public Management EnterFirstName()
        {
            IWebElement firstNameFld = Browser._Driver.FindElement(By.XPath("//*[contains(@AutomationId, 'UserFirstNameTbx')]"));
            
            firstNameFld.SendKeys("Jane");
            /*lastNameFld.SendKeys("Doe");
            emailFld.SendKeys("qatester91311@gmail.com");
            phoneFld.SendKeys("+123654789");
            faxFld.SendKeys("+1365477984");
            addressFld.SendKeys("9 County Road CC 3/10");
            cityFld.SendKeys("Wray");
            zipFld.SendKeys("80358");*/

            return this;
        }
        [AllureStep("Enter the user Last Name")]
        public Management EnterLastName()
        {
            IWebElement lastNameFld = Browser._Driver.FindElement(By.XPath("//*[contains(@AutomationId, 'UserLastNameTbx')]"));
            lastNameFld.SendKeys("Doe");

            return this;
        }

        [AllureStep("Enter the user Email")]
        public Management EnterEmail()
        {
            IWebElement emailFld = Browser._Driver.FindElement(By.XPath("//*[contains(@AutomationId, 'EmailTbx')]"));
            emailFld.SendKeys("qatester91311@gmail.com");

            return this;
        }
        [AllureStep("Enter the user Phone")]
        public Management EnterPhone()
        {
            IWebElement phoneFld = Browser._Driver.FindElement(By.XPath("//*[contains(@AutomationId, 'PhoneTbx')]"));
            phoneFld.SendKeys("+123654789");

            return this;
        }
        [AllureStep("Enter the user Fax")]
        public Management EnterFax()
        {
            IWebElement faxFld = Browser._Driver.FindElement(By.XPath("//*[contains(@AutomationId, 'FaxTbx')]"));
            faxFld.SendKeys("+1365477984");

            return this;
        }
        [AllureStep("Enter the user Address")]
        public Management EnterAddress()
        {
            IWebElement addressFld = Browser._Driver.FindElement(By.XPath("//*[contains(@AutomationId, 'Address1Tbx')]"));
            addressFld.SendKeys("9 County Road CC 3/10");

            return this;
        }
        [AllureStep("Enter the user City")]
        public Management EnterCity()
        {
            IWebElement cityFld = Browser._Driver.FindElement(By.XPath("//*[contains(@AutomationId, 'CityTbx')]"));
            cityFld.SendKeys("Wray");

            return this;
        }
        [AllureStep("Enter the user Zip")]
        public Management EnterZip()
        {
            IWebElement zipFld = Browser._Driver.FindElement(By.XPath("//*[contains(@AutomationId, 'ZipCodeTbx')]"));
            zipFld.SendKeys("80358");

            return this;
        }

        [AllureStep("Activate User")]
        public Management ActivateUser()
        {
            accStatusBtn.SendKeys(Keys.Control);
            new Actions(Browser._Driver)
                .Release(accStatusBtn)
                .Build()
                .Perform();
            accStatusBtn.Click();
            return this;
        }

        [AllureStep("Open User notes modal")]
        public Management OpenUserNotesModal()
        {
            accNotesBtn.SendKeys(Keys.Control);
            new Actions(Browser._Driver)
                .Release(accNotesBtn)
                .Build()
                .Perform();
            accNotesBtn.Click();
            return this;
        }

        [AllureStep("Add User notes and Save")]
        public Management AddUserNotes()
        {
            Pages.Common.SwitchWindow();

            noteTextArea.SendKeys("Lorem ipsum");
            noteSaveBtn.Click();
            return this;
        }

        [AllureStep("Add filters")]
        public Management AddFilters()
        {
            IWebElement filterFld = Browser._Driver.FindElement(By.XPath("//*[contains(@AutomationId, 'CalibrationFilterTbx')]"));
            IWebElement filterDescrFld = Browser._Driver.FindElement(By.XPath("//*[contains(@AutomationId, 'DescriptionFilterTbx')]"));
            IWebElement andRadioBtn = Browser._Driver.FindElement(By.XPath("//*[contains(@AutomationId, 'AndOperationRbtn')]"));
            IWebElement orRadioBtn = Browser._Driver.FindElement(By.XPath("//*[contains(@AutomationId, 'OrOperationRbtn')]"));
            IWebElement addFilterBtn = Browser._Driver.FindElement(By.XPath("//*[contains(@AutomationId, 'AddFilterBtn')]"));

            filterFld.SendKeys("034");
            filterDescrFld.SendKeys("034");
            andRadioBtn.Click();
            addFilterBtn.Click();
            filterFld.Clear();
            filterDescrFld.Clear();
            filterFld.SendKeys("Qa");
            filterDescrFld.SendKeys("Qa");
            andRadioBtn.Click();
            addFilterBtn.Click();
            filterFld.Clear();
            filterDescrFld.Clear();
            filterFld.SendKeys("Test");
            filterDescrFld.SendKeys("Test");
            andRadioBtn.Click();
            addFilterBtn.Click();
            filterFld.Clear();
            filterDescrFld.Clear();
            filterFld.SendKeys("123");
            filterDescrFld.SendKeys("123");
            orRadioBtn.Click();
            addFilterBtn.Click();
            filterFld.Clear();
            filterDescrFld.Clear();
            filterFld.SendKeys("Test");
            filterDescrFld.SendKeys("Test");
            andRadioBtn.Click();
            addFilterBtn.Click();
            filterFld.Clear();
            filterDescrFld.Clear();

            return this;
        }

        #region For 034 and JHM browsers
        [AllureStep("Find and select country from list")]
        public Management FindCountryInput(string Country)
        {
            countryCbbx.SendKeys(Keys.Control);
            new Actions(Browser._Driver)
               .Release()
               .Build()
               .Perform();
            countryCbbx.Click();
            countryCbbx.FindElement(By.Name(Country)).Click();

            return this;
        }

        [AllureStep("Find and select user role")]
        public Management FindRoleInput(string Role)
        {
            roleCbbx.SendKeys(Keys.Control);
            new Actions(Browser._Driver)
               .Release()
               .Build()
               .Perform();
            roleCbbx.Click();
            roleCbbx.FindElement(By.Name(Role)).Click();

            return this;
        }

        [AllureStep("Find and Enter the Username")]
        public Management FindUserNameInput(string userName)
        {
            usernameFld.SendKeys(Keys.Control);
            new Actions(Browser._Driver)
               .Release()
               .Build()
               .Perform();
            usernameFld.SendKeys(userName + DateTimeOffset.Now.ToUnixTimeMilliseconds());

            return this;
        }

        [AllureStep("Find and Enter the Password")]
        public Management FindPasswordInput(string Password)
        {
            userConfPasswordFld.SendKeys(Keys.Control);
            new Actions(Browser._Driver)
               .Release()
               .Build()
               .Perform();
            userConfPasswordFld.SendKeys(Password);

            return this;
        }

        [AllureStep("Click \"Save\" button")]
        public Management FindSaveUserBtn()
        {
            saveUserBtn.SendKeys(Keys.Control);
            new Actions(Browser._Driver)
               .Release()
               .Build()
               .Perform();
            saveUserBtn.Click();

            return this;
        }


        public Management FindDeleteUserBtn()
        {
            userDeleteBtn.SendKeys(Keys.Control);
            new Actions(Browser._Driver)
               .Release()
               .Build()
               .Perform();
            userDeleteBtn.Click();

            return this;
        }

        #endregion
        public Management ClickToScroll()
        {
            userDeleteBtn.SendKeys(Keys.Control);
            new Actions(Browser._Driver)
                .SendKeys(Keys.PageDown)
                .Release()
                .Build()
                .Perform();
            WaitUntil.WaitSomeInterval(1);

            return this;
        }

        [AllureStep("Select user")]
        public Management SelectUser()
        {

            IReadOnlyCollection<IWebElement> treeItems = Browser._Driver.FindElementsByXPath("//*[contains(@Name, 'testautomation')]");

            IWebElement userName = Browser._Driver.FindElementByXPath("//*[contains(@Name, 'testautomation')]");
            foreach (var item in treeItems)
            {

                if (item.Displayed && item.Text == userName.Text)
                {
                    new Actions(Browser._Driver)
                   .Click(item)
                   .Build()
                   .Perform();
                    break;
                }

            }

            return this;
        }

        [AllureStep("Click \"Delete User\" button")]
        public Management ClickDeleteUserBtn()
        {
            /*IReadOnlyCollection<IWebElement> treeItems = Browser._Driver.FindElementsByXPath("//*[contains(@Name, 'DELETE USER')]");
            IWebElement selectUser = null;

            foreach (var item in treeItems)
            {

                if (!item.Enabled)
                {
                    new Actions(Browser._Driver)
                        .SendKeys(Keys.Tab);
                    break;
                }
                selectUser = item;
                selectUser.Click();

            }*/
            WaitUntil.VisibleAndClickable(_userDeleteBtn);
            userDeleteBtn.Click();

            return this;
        }

        public Management ScrollDown()
        {

            new Actions(Browser._Driver)
                .SendKeys(Keys.Control + Keys.End)
                .Build()
                .Perform();
            WaitUntil.WaitSomeInterval(1);
            return this;
        }

        [AllureStep("Get UserName label")]
        public string GetUserNameLabel()
        {
            string label = usernameFld.Text;
            return label;
        }
    }
}
