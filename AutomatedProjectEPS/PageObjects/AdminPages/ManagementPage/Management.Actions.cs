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
            refreshBtn.SendKeys(Keys.Control);
            new Actions(Browser._Driver)
               .Release(refreshBtn)
               .Build()
               .Perform();
            AddUserBtn.Click();

            return this;
        }


        [AllureStep("Enter the user First Name")]
        public Management EnterFirstName()
        {
            firstNameFld.SendKeys(Keys.Control);
            new Actions(Browser._Driver)
               .Release()
               .Build()
               .Perform();
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
        [AllureStep("Enter the user Last Name")]
        public Management EnterLastName()
        {

            lastNameFld.SendKeys("Doe");

            return this;
        }

        [AllureStep("Enter the user Email")]
        public Management EnterEmail()
        {
            emailFld.SendKeys("qatester91311@gmail.com");

            return this;
        }
        [AllureStep("Enter the user Phone")]
        public Management EnterPhone()
        {
            phoneFld.SendKeys("+123654789");

            return this;
        }
        [AllureStep("Enter the user Fax")]
        public Management EnterFax()
        {
            faxFld.SendKeys("+1365477984");

            return this;
        }
        [AllureStep("Enter the user Address")]
        public Management EnterAddress()
        {
            addressFld.SendKeys("9 County Road CC 3/10");

            return this;
        }
        [AllureStep("Enter the user City")]
        public Management EnterCity()
        {
            cityFld.SendKeys("Wray");

            return this;
        }
        [AllureStep("Enter the user Zip")]
        public Management EnterZip()
        {
            zipFld.SendKeys("80358");

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
            /* IReadOnlyCollection<IWebElement> treeItems = Browser._Driver.FindElements(_countryCbbx);
             IWebElement countryInput = null;
             foreach (var item in treeItems)
             {
                 new Actions(Browser._Driver)
                .SendKeys(Keys.Tab)
                .Build()
                .Perform();
                 countryInput = item;

                 if (item.Displayed)
                 {
                     countryInput.Click();
                     countryCbbx.FindElement(By.Name(Country)).Click();
                     break;
                 }

             }*/

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
            /*IReadOnlyCollection<IWebElement> treeItems = Browser._Driver.FindElements(_roleCbbx);
            IWebElement Item = null;
            foreach (var item in treeItems)
            {
                new Actions(Browser._Driver)
               .SendKeys(Keys.Tab)
               .Build()
               .Perform();
                Item = item;

                if (item.Displayed)
                {
                    Item.Click();
                   *//* WaitUntil.ElementIsVisible(By.Name(Role));*//*
                    roleCbbx.FindElement(By.Name(Role)).Click();
                    break;
                }

            }*/

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
            /* IReadOnlyCollection<IWebElement> treeItems = Browser._Driver.FindElements(_usernameFld);
             IWebElement Item = null;
             foreach (var item in treeItems)
             {
                 new Actions(Browser._Driver)
                   .SendKeys(Keys.Tab)
                   .Build()
                   .Perform();
                 Item = item;

                 if (item.Displayed)
                 {
                     Item.Click();
                     usernameFld.SendKeys(userName + DateTimeOffset.Now.ToUnixTimeMilliseconds());
                     break;
                 }

             }*/

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
            /*IReadOnlyCollection<IWebElement> treeItems = Browser._Driver.FindElements(_userConfPasswordFld);
            IWebElement Item = null;
            foreach (var item in treeItems)
            {
                new Actions(Browser._Driver)
                   .SendKeys(Keys.Tab)
                   .Build()
                   .Perform();
                Item = item;

                if (item.Displayed)
                {
                    Item.Click();
                    userConfPasswordFld.SendKeys(Password);
                    break;
                }
                
            }*/

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
            /*IReadOnlyCollection<IWebElement> treeItems = Browser._Driver.FindElements(_saveUserBtn);
            IWebElement Item = null;
            foreach (var item in treeItems)
            {
                new Actions(Browser._Driver)
                   .SendKeys(Keys.Tab)
                   .Build()
                   .Perform();
                Item = item;

                if (item.Displayed)
                {
                    Item.Click();
                    break;
                }
                
            }
            */
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
            /*WaitUntil.VisibleAndClickable(_clickImg);
            IReadOnlyCollection<IWebElement> treeItems = Browser._Driver.FindElements(_userDeleteBtn);
            IWebElement Item = null;
            foreach (var item in treeItems)
            {

                if (!item.Selected)
                {
                    new Actions(Browser._Driver)
                        .MoveToElement(clickImg)
                        .Click()
                        .Release()
                        .Build()
                        .Perform();
                    new Actions(Browser._Driver)
                        .SendKeys(Keys.Control + Keys.End)
                        .Build()
                        .Perform();
                    new Actions(Browser._Driver)
                        .SendKeys(Keys.Control)
                        .Build()
                        .Perform();
                    Item = item;
                    *//* Item.Click();*//*
                    break;
                }

            }*/

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
