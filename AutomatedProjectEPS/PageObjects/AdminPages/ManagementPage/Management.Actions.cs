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
using static AutomatedProjectEPS.ClassHelpers.ListsHelper;

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
            WaitUntil.ElementIsVisible(_searchFld);
            searchFld.Clear();
            searchFld.SendKeys(userName);
            WaitUntil.InvisibilityOfLoader();
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
            firstNameFld.SendKeys(Keys.Control);
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

        [AllureStep("Edit the user Data")]
        public Management EditUserData()
        {
            firstNameFld.Clear();
            firstNameFld.SendKeys("Edited-Jane");
            lastNameFld.Clear();
            lastNameFld.SendKeys("Edited-Doe");
            emailFld.Clear();
            emailFld.SendKeys("Edited-qatester91311@gmail.com");
            phoneFld.Clear();
            phoneFld.SendKeys("85468949");
            faxFld.Clear();
            faxFld.SendKeys("+369852147");
            addressFld.Clear();
            addressFld.SendKeys("Edited-9 County Road CC 3/10 " + DateTimeOffset.Now);
            cityFld.Clear();
            cityFld.SendKeys("BestCity");
            zipFld.Clear();
            zipFld.SendKeys("6587SS");

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
        [AllureStep("Activate flashcount limit")]
        public Management ActivateFlashLimit()
        {
            flashCountBtn.Click();
            
            return this;
        }

        [AllureStep("Increase flash Limit by 1")]
        public Management ClickIncreaseFlashLimitBtn()
        {
            flashIncreaseLimitBtn.Click();

            return this;
        }

        [AllureStep("Decrease flash Limit by 1")]
        public Management ClickDecreaseFlashLimitBtn()
        {
            flashDecreaseLimitBtn.Click();

            return this;
        }

        [AllureStep("Change flash Limit by enter numbers from keyboard")]
        public Management EditFlashLimitField()
        {
            flashCountFld.Clear();
            flashCountFld.SendKeys("99999");

            return this;
        }

        [AllureStep("Deactivate flashcount limit")]
        public Management DeactivateFlashLimit()
        {
            if(flashCountFld.Displayed == true)
            {
                flashCountBtn.Click();
            }
            

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

        [AllureStep("Remove filters")]
        public Management RemoveFilters()
        {
            IReadOnlyCollection<IWebElement> removeBtn = Browser._Driver.FindElementsByAccessibilityId("RemoveFilterBtn");
            foreach (var item in removeBtn)
            {
                if(item != null && item.Displayed == true)
                {
                    ArrayList filters = new ArrayList();
                    for (int i = 0; i < removeBtn.Count; i++)
                    {
                        filters.Add(item);

                    }


                    foreach (var f in filters)
                    {
                        removeFilterBtn.Click();
                    }
                }
                
                return this;
            }
            return this;
        }

        [AllureStep("Test filter")]
        public Management ClickTestFilter(string filter)
        {
            IReadOnlyCollection<IWebElement> testBtn = Browser._Driver.FindElementsByAccessibilityId("TestFilterBtn");
            foreach (var item in testBtn)
            {
                if (item != null && item.Displayed == true)
                {
                    ArrayList filters = new ArrayList();
                    for (int i = 0; i < testBtn.Count; i++)
                    {
                        filters.Add(item);

                    }
                   
                    for (int i = 0; i < testBtn.Count; i++)
                    {

                        testFilterBtn.Click();
                        CheckFilterData();
                        CloseListBtn.Click();
                        Console.WriteLine(CheckFilterData());
                    }
                    /*foreach (var f in filters)
                    {
                        testFilterBtn.Click();
                        Pages.Common.SwitchWindow();
                        string xPath = "//*[contains(text(), '" + filter + "')]";
                        EcusListPopUp.FindElements(By.XPath(xPath));
                        CloseListBtn.Click();
                    }*/
                }

                
            }
            return this;
        }

       // [AllureStep ("Verify filters data is shown")]

      //  public Management CheckFilterData()
      //  {
            
         //   Pages.Common.SwitchWindow();
          //  List<string> givenList = new List<string>();
          //  List<string> filteredList = new List<string>();
          //  List<IWebElement> list = new List<IWebElement>(Browser._Driver.FindElements(By.XPath("//*/List[@AutomationId=\"EcusList\"]/ListItem")));
          //  foreach(var l in list)
          //  {
                
           //     givenList.Add(l.Text);
                
          //  }
          //  List<IWebElement> list1 = new List<IWebElement>(Browser._Driver.FindElements(By.XPath("//*/List[@AutomationId=\"EcusList\"]/ListItem")));
         //   foreach (var listItem in list1)
         //   {
        //        filteredList.Add(listItem.Text);
        //    }
         //   var firstList = givenList.Except(filteredList).ToString();
        //    var secondList = filteredList.Except(givenList).ToString();

         //   return !firstList.Any() && !secondList.Any();
      //  }

        #region For 034 and JHM browsers
        [AllureStep("Find and select country from list")]
        public Management FindCountryInput(string Country)
        {
            countryCbbx.SendKeys(Keys.Control);
            
            countryCbbx.Click();
            countryCbbx.SendKeys(Country);
            countryCbbx.FindElement(By.Name(Country)).Click();

            return this;
        }

        [AllureStep("Find and select user role")]
        public Management FindRoleInput(string Role)
        {
            roleCbbx.SendKeys(Keys.Control);
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

        [AllureStep("Get FirstName")]
        public string GetUserFirstName()
        {
            string label = firstNameFld.Text;
            return label;
        }
        #endregion

        #region DealearActions

        [AllureStep("Select dealer")]
        public Management SelectDealer()
        {

            IReadOnlyCollection<IWebElement> treeItems = Browser._Driver.FindElementsByXPath("//*[contains(@Name, 'Jane')]");

            IWebElement dealerName = Browser._Driver.FindElementByXPath("//*[contains(@Name, 'Jane')]");
            foreach (var item in treeItems)
            {

                if (item.Displayed && item.Text == dealerName.Text)
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

        [AllureStep("Enter root Dealer Data")]
        public Management EnterRootDealerData(string company)
        {
            /*CompanyNameTbx.Clear();*/
            CompanyNameTbx.SendKeys(Keys.Control);
            CompanyNameTbx.SendKeys(company);
            ContactNameTbx.Clear();
            ContactNameTbx.SendKeys("Doe");
            emailFld.Clear();
            emailFld.SendKeys("qatester91311@gmail.com");
            phoneFld.Clear();
            phoneFld.SendKeys("+123654789");
            AddressTbx.Clear();
            AddressTbx.SendKeys("9 County Road CC 3/10");
            cityFld.Clear();
            cityFld.SendKeys("Wray");
            StateCbbx.Clear();
            StateCbbx.SendKeys("DF");

            return this;
        }

        [AllureStep("Enter Nested Dealer Data")]
        public Management EnterNestedDealerData()
        {
            /*CompanyNameTbx.Clear();*/
            CompanyNameTbx.SendKeys("Jane QA" + " " + DateTimeOffset.Now.ToUnixTimeMilliseconds());
            ContactNameTbx.Clear();
            ContactNameTbx.SendKeys("Doe");
            emailFld.Clear();
            emailFld.SendKeys("qatester91311@gmail.com");
            phoneFld.Clear();
            phoneFld.SendKeys("+123654789");
            AddressTbx.Clear();
            AddressTbx.SendKeys("9 County Road CC 3/10");
            cityFld.Clear();
            cityFld.SendKeys("Wray");
            StateCbbx.Clear();
            StateCbbx.SendKeys("DF");

            return this;
        }

        [AllureStep("Edit Dealer Data")]
        public Management EditDealerData()
        {
            CompanyNameTbx.Clear();
            CompanyNameTbx.SendKeys("Jane" + " " + DateTimeOffset.Now.ToUnixTimeMilliseconds() + " Edited");
            ContactNameTbx.Clear();
            ContactNameTbx.SendKeys("QA");
            emailFld.Clear();
            emailFld.SendKeys("qatester91311@gmail.com");
            phoneFld.Clear();
            phoneFld.SendKeys("+(123) 654789");
            AddressTbx.Clear();
            AddressTbx.SendKeys("2268 S Tongass Hwy, Ketchikan, Alaska 99901, USA");
            cityFld.Clear();
            cityFld.SendKeys("Ketchikan");
            StateCbbx.Clear();
            StateCbbx.SendKeys("AK");

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

            noteTextArea.SendKeys("Phone number: (907) 826-3317 \n Street: 245 Cold Storage Rd \n City: Craig \n State: Alaska(AK) \n Zipcode: 99921 \n Country: USA \n Address: 245 Cold Storage Rd, Craig, Alaska 99921, USA \n");
            noteSaveBtn.Click();
            return this;
        }

        [AllureStep("Clear User notes and Save")]
        public Management ClearDealerNotes()
        {
            Pages.Common.SwitchWindow();

            noteTextArea.Clear();
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
