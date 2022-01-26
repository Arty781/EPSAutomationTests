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

        
        public void CheckIsflashingsDisplayed(string distributor)
        {
            WaitUntil.InvisibilityOfElementLocated(Pages.Common._Loader);
            IReadOnlyCollection<IWebElement> report = Browser._Driver.FindElements(_gridCell);
            string flashitem = null;
            foreach (var item in report)
            {
                flashitem = item.Text;
                if (report.Count != 0)
                {
                    if(flashitem == distributor)
                    {
                        break;
                    }
                    
                }
                Console.WriteLine($"Flashing with distributor \"{0}\" has not found", item);
            }
            Assert.IsTrue(PresenceOfElement.IsElementPresent(By.Name(flashitem)));
        }
    }
}
