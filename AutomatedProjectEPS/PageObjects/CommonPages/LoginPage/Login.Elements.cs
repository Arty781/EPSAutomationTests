using AutomatedProjectEPS.ClassHelpers;
using OpenQA.Selenium;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class Login
    {

        public IWebElement inputUserName => Browser._Driver.FindElement(_inputUserName);
        public readonly By _inputUserName = By.XPath("//*[contains(@AutomationId, 'UserNameTbx')]");

        public IWebElement inputPassword => Browser._Driver.FindElement(_inputPassword);
        public readonly By _inputPassword = By.XPath("//*[contains(@AutomationId, 'UserPasswordPbx')]");

        public IWebElement btnLogin => Browser._Driver.FindElement(_btnLogin);
        public readonly By _btnLogin = By.XPath("//*[contains(@AutomationId, 'LoginBtn')]");

        public IWebElement btnResetPassword => Browser._Driver.FindElement(_btnResetPassword);
        public readonly By _btnResetPassword = By.XPath("//*[contains(@AutomationId, 'ResetPasswordTb')]");

        public IWebElement btnRememberMe => Browser._Driver.FindElement(_btnRememberMe);
        public readonly By _btnRememberMe = By.XPath("//*[contains(@AutomationId, 'RememberMeChbx')]");

        public IWebElement cbbxServer => Browser._Driver.FindElement(_cbbxServer);
        public readonly By _cbbxServer = By.XPath("//*[contains(@AutomationId, 'ServerCbbx')]");








      


    }
}
