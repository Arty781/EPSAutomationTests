using AutomatedProjectEPS.ClassHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class History
    {
        public void CompareFlashHistory(string distributor) 
        {
            WaitUntil.WaitSomeInterval(5);
            List<string> flashHistory = new AppDbContext().GetSerialNumbersList(distributor);
            foreach (string flash in flashHistory)
            {
                if (Browser._Driver.FindElementByName(flash) != null)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Flash history isn't found");
                }
                
            }
            
        }
    }
}
