using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Steps;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class Login
    {
        

        [AllureStep("Enter user's email: {0}")]
        public Login EnterLogin(string email)
        {
            WaitUntil.ElementIsVisible(_inputUserName);
            inputUserName.Clear();
            inputUserName.SendKeys(email);
            return this;
        }

        [AllureStep("Enter user's password: {0}")]
        public Login EnterPassword(string password)
        {
            inputPassword.Clear();
            inputPassword.SendKeys(password);
            return this;
        }

        [AllureStep("Press login button")]
        public Controller PressLoginButton()
        {
            
            btnLogin.Click();
            WaitUntil.WaitSomeInterval(2);
           

            return Pages.Controller;
        }


        [AllureStep("Select {0} server")]
        public Login SelectServer(string server)
        {
            WaitUntil.ElementIsClickable(_cbbxServer);
            cbbxServer.Click();
            IReadOnlyCollection<IWebElement> serverList = Browser._Driver.FindElementsByAccessibilityId("ServerNameTb");
            foreach(var item in serverList)
            {

                if(item.Displayed == true && item.Text == server)
                {
                    item.Click();
                }
                
            }
            return this;
        }

        [AllureStep("Enter user's password: {0}")]
        public Login AdminPass(string password)
        {
            IWebElement elem = Browser._Driver.FindElementByAccessibilityId("Password");
            elem.Clear();
            elem.SendKeys(password);
            return this;
        }

        [AllureStep("Press login button")]
        public Controller LogAdmin()
        {
            IWebElement elem = Browser._Driver.FindElementByAccessibilityId("LoginBtn");
            elem.Click();
            WaitUntil.WaitSomeInterval(2);

            return Pages.Controller;
        }
    }
}
