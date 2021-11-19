using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.ClassHelpers
{
    public class LazarusApp
    {
        private WindowsDriver<WindowsElement> driver;
        public LazarusApp(WindowsDriver<WindowsElement> driver)
        {
            this.driver = driver;
        }


        public void InitController(string controller)
        {
            IWebElement cbbxControllers =
                driver.FindElement(By.XPath("//*[contains(@AutomationId, 'comboBox_predefEcu')]"));
            IWebElement btnInit =
                driver.FindElement(By.XPath("//*[contains(@AutomationId, 'button_InitStop')]"));

            cbbxControllers.Click();
            cbbxControllers.FindElement(By.Name(controller)).Click();
            btnInit.Click();
        }
    }
}
