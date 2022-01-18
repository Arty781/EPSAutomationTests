using AutomatedProjectEPS.ClassHelpers;
using OpenQA.Selenium;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class Login
    {

        public IWebElement inputUserName => Browser._Driver.FindElementByAccessibilityId("UserNameTbx");
        public readonly By _inputUserName = By.XPath("//*[contains(@AutomationId, 'UserNameTbx')]");

        public IWebElement inputPassword => Browser._Driver.FindElementByAccessibilityId("UserPasswordPbx");
        public readonly By _inputPassword = By.XPath("//*[contains(@AutomationId, 'UserPasswordPbx')]");

        public IWebElement btnLogin => Browser._Driver.FindElementByAccessibilityId("LoginBtn");
        public readonly By _btnLogin = By.XPath("//*[contains(@AutomationId, 'LoginBtn')]");

        public IWebElement btnResetPassword => Browser._Driver.FindElementByAccessibilityId("ResetPasswordTb");
        public readonly By _btnResetPassword = By.XPath("//*[contains(@AutomationId, 'ResetPasswordTb')]");

        public IWebElement btnRememberMe => Browser._Driver.FindElementByAccessibilityId("RememberMeChbx");
        public readonly By _btnRememberMe = By.XPath("//*[contains(@AutomationId, 'RememberMeChbx')]");

        public IWebElement cbbxServer => Browser._Driver.FindElementByAccessibilityId("ServerCbbx");
        public readonly By _cbbxServer = By.XPath("//*[contains(@AutomationId, 'ServerCbbx')]");

        public IWebElement serverNameTb => Browser._Driver.FindElementByAccessibilityId("ServerNameTb");
        public readonly By _serverNameTb = By.XPath("//*[contains(@AutomationId, 'ServerNameTb')]");

        public IWebElement ErrorMessage => Browser._Driver.FindElementByAccessibilityId("ErrorMessageTb");
        public readonly By _ErrorMessage = By.XPath("//*[contains(@AutomationId, 'ErrorMessageTb')]");










    }
}
