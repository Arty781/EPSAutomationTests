using AutomatedProjectEPS.ClassHelpers;
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
        /*public void CompareFlashHistory(string distributor)
        {

            List<string> flashHistory = new AppDbContext().GetSerialNumbersList(distributor);
            string flashitem = null;
            foreach (string flash in flashHistory)
            {
                if (flashHistory.Count != 0)
                    {
                    flashitem = flash;
                        if (PresenceOfElement.IsElementPresent(By.Name(flash)) == true)
                        {
                            break;
                        }
                        WaitUntil.WaitSomeInterval(5);
                    }
                Console.WriteLine("Flashing with serial number \"{0}\" has not found", flashitem);
            }
             Assert.IsTrue(PresenceOfElement.IsElementPresent(By.Name(flashitem)));
        }*/

        public void CatchException(string locator)
        {
            Assert.IsTrue(PresenceOfElement.IsElementPresent(By.Name(locator)));
        }

        public void CheckIsflashingsDisplayed(string distributor)
        {
            PresenceOfElement.IsLoaderDisplay();
            IReadOnlyCollection<IWebElement> report = Browser._Driver.FindElements(By.XPath("//Custom[@ClassName=\"DataGridCell\"][3]"));
            IWebElement row = null;

            foreach (var item in report)
            {
                row = item;
                Assert.AreEqual(distributor, row.Text);
            }


        }
    }
}
