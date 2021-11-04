using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Steps;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System.Collections.Generic;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class Login
    {
        

        [AllureStep("Enter user's email: {0}")]
        public Login EnterLogin(string email)
        {
            WaitUntil.WaitSomeInterval();
            


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


        [AllureStep("Enter user's email: {0}")]
        public Login Admin(string email)
        {
            WaitUntil.WaitSomeInterval();
            IWebElement elem = Browser._Driver.FindElementByAccessibilityId("UserNameInput");
            elem.Clear();
            elem.SendKeys(email);
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
