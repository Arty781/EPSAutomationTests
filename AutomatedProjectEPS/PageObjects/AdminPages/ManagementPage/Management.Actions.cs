using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Steps;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomatedProjectEPS.PageObjects
{
    public partial class Management
    {

        [AllureStep("Search User {0}")]
        public Management SearchUser034(string userName)
        {
            searchFld.SendKeys(userName);
            searchBtn034.Click();


            return this;
        }

        [AllureStep("Search User")]
        public Management SearchUser(string userName)
        {
            searchFld.Clear();
            searchFld.SendKeys(userName);
            searchBtn.Click();


            return this;
        }

        [AllureStep("Open Root Tree")]
        public Management OpenRootTree()
        {
            WaitUntil.InvisibilityOfLoader();
            ExpanderBtn.Click();
            
            return this;
        }

        [AllureStep("Open Nested Tree")]
        public Management OpenNestedTree()
        {
            WaitUntil.InvisibilityOfLoader();
            ExpanderBtn.Click();
            IReadOnlyCollection<IWebElement> expanders = Browser._Driver.FindElementsByAccessibilityId("Expander");
            ExpanderBtn.Click();
            foreach (var item in expanders)
            {
                
                if (item.Displayed == true)
                {
                    
                    item.Click();
                }

            }
            return this;
        }
        #region UserActions
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


        [AllureStep("Enter the user Data")]
        public Management EnterUserData()
        {
            firstNameFld.SendKeys("Jane");
            lastNameFld.SendKeys("Doe");
            emailFld.SendKeys("qatester91311@gmail.com");
            phoneFld.SendKeys("+123654789");
            faxFld.SendKeys("+1365477984");
            addressFld.SendKeys("9 County Road CC 3/10");
            cityFld.SendKeys("Wray");
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
        public Management AddMultipleFilters(string filter)
        {
            ArrayList filters = new ArrayList();
            filters.AddRange(new string[] { filter, "Qa", "Test" });
            for(int i = 0; i < filters.Count; i++)
            {
                
                filterFld.SendKeys(filters[i].ToString());
                filterDescrFld.SendKeys(filters[i].ToString());
                andRadioBtn.Click();
                addFilterBtn.SendKeys(Keys.Control);
                addFilterBtn.Click();
                filterFld.Clear();
                filterDescrFld.Clear();
            }

            return this;
        }

        #region For 034 and JHM browsers
        [AllureStep("Find and select country from list")]
        public Management FindCountryInput(string Country)
        {
            countryCbbx.SendKeys(Keys.Control);
            
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
            Pages.Common.SwitchWindow();
            Assert.AreNotEqual(Browser._Driver.FindElementByAccessibilityId("Messagebox").Text, "Unable to connect to the server. \r\nPlease contact the appropriate Technical Support Representative.");

            return this;
        }


        public Management FindDeleteUserBtn()
        {
            userDeleteBtn.SendKeys(Keys.Control);
            new Actions(Browser._Driver)
               .Release(userDeleteBtn)
               .Build()
               .Perform();
            userDeleteBtn.Click();

            return this;
        }

        #endregion
        
        [AllureStep("Select user")]
        public Management SelectUser()
        {

            IReadOnlyCollection<IWebElement> treeItems = Browser._Driver.FindElementsByXPath("//*[contains(@Name, 'testautomationQA')]");

            IWebElement userName = Browser._Driver.FindElementByXPath("//*[contains(@Name, 'testautomationQA')]");
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
            WaitUntil.InvisibilityOfLoader();
            userDeleteBtn.SendKeys(Keys.Control);
            new Actions(Browser._Driver)
                .SendKeys(Keys.PageDown)
                .Release()
                .Build()
                .Perform();
            WaitUntil.WaitSomeInterval(1);
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
        #endregion

        #region DealearActions
       
        [AllureStep("Select dealer")]
        public Management SelectDealer()
        {
           
            IReadOnlyCollection<IWebElement> addBtnCollection = Browser._Driver.FindElementsByAccessibilityId("AddDealerBtn");
            foreach (var item in addBtnCollection)
            {
                if (item.Displayed == true)
                {
                    
                    item.Click();
                }

            }
           
            return this;
        }

        [AllureStep("Press \"Add Dealer\" Button")]
        public Management PressAddDealerBtn()
        {
            IReadOnlyCollection<IWebElement> addBtnCollection = Browser._Driver.FindElementsByAccessibilityId("AddDealerBtn");
            foreach (var item in addBtnCollection)
            {
                if (item.Displayed == true)
                {
                    item.Click();
                }

            }

            return this;
        }

        [AllureStep("Enter Dealer Data")]
        public Management EnterDealerData()
        {
            CompanyNameTbx.SendKeys("Jane QA" + " " +DateTimeOffset.Now.ToUnixTimeMilliseconds());
            ContactNameTbx.SendKeys("Doe");
            emailFld.SendKeys("qatester91311@gmail.com");
            phoneFld.SendKeys("+123654789");
            AddressTbx.SendKeys("9 County Road CC 3/10");
            cityFld.SendKeys("Wray");
            StateCbbx.SendKeys("DF");
            
            return this;
        }

        [AllureStep("Activate User")]
        public Management ActivateDealer()
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
        public Management OpenDealerNotesModal()
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
        public Management AddDealerNotes()
        {
            Pages.Common.SwitchWindow();

            noteTextArea.SendKeys("Lorem ipsum");
            noteSaveBtn.Click();
            return this;
        }

        [AllureStep("Select Region")]
        public Management SelectRegion()
        {

            RegionsCbbx.SendKeys(Keys.Control);
            new Actions(Browser._Driver)
               .Release()
               .Build()
               .Perform();
            RegionsCbbx.Click();
            RegionsCbbx.FindElement(By.Name("Europe")).Click();
            return this;
        }

        [AllureStep("Get Company label")]
        public string GetCompanyLabel()
        {
            string label = CompanyNameTbx.Text;
            return label;
        }

        [AllureStep("Click \"Save\" button")]
        public Management ClickSaveDealerBtn()
        {
            SaveDistributorBtn.SendKeys(Keys.Control);
            SaveDistributorBtn.SendKeys(Keys.Control);
            new Actions(Browser._Driver)
               .Release()
               .Build()
               .Perform();
            SaveDistributorBtn.Click();

            return this;
        }

        #endregion
    }

}
