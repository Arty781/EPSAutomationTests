using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Steps;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class History
    {
        [AllureStep("Change Start Date")]
        public History ChangeStartDate()
        {
            PresenceOfElement.IsLoaderDisplay();
            WaitUntil.ElementIsClickable(_datePicker);
            datePicker.Clear();
            datePicker.SendKeys(DateTime.UtcNow.AddMonths(-1).ToShortDateString());

            return this;
        }


        [AllureStep("Select Distributor")]
        public History SelectDistributor(string distributorName)
        {
            PresenceOfElement.IsLoaderDisplay();
            WaitUntil.VisibleAndClickable(_cbbxDistributor);
            new Actions(Browser._Driver)
                 .Click(cbbxDistributor)
                 .Build()
                 .Perform();

            IReadOnlyCollection<IWebElement> treeItems = Browser._Driver.FindElementsByAccessibilityId("DistributorNameTb");
            foreach (var item in treeItems)
            {
                if (!item.Selected && PresenceOfElement.IsElementPresent(By.Name(distributorName)) == true)
                {
                    IWebElement selectedDistr = item;

                    if (selectedDistr.Enabled && selectedDistr.Text == distributorName)
                    {
                        new Actions(Browser._Driver)
                        .SendKeys(Keys.ArrowUp)
                        .Click(selectedDistr)
                        .Build()
                        .Perform();
                        break;
                    }
                    new Actions(Browser._Driver)
                    .SendKeys(Keys.ArrowDown)
                    .Build()
                    .Perform();

                }
                CatchException(distributorName);

            }

            return this;
        }

        [AllureStep("Press 'Get Report' button")]
        public History PressGetReportButton()
        {
            WaitUntil.ElementIsClickable(_btnGetReport);
            btnGetReport.Click();

            return this;
        }

        public History ScrollDown()
        {
            new Actions(Browser._Driver)
                .SendKeys(Keys.Control + Keys.End)
                .Build()
                .Perform();
            WaitUntil.WaitSomeInterval(1);
            return this;
        }
    }
}
