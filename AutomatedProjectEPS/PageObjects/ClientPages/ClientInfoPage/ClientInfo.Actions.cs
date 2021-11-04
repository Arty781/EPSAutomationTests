using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Steps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedProjectEPS.PageObjects
{
    public partial class ClientInfo
    {
        [AllureStep("Fill client info")]
        public ClientInfo FillClientInfo()
        {
            WaitUntil.ElementIsVisible(_inputFirstName, 45);
            if(inputFirstName.Text != "")
            {
                return this;
            }
            else
            {
                inputFirstName.SendKeys("qafirstnameqa");
                inputLastName.SendKeys("qalastname");
                inputAddress.SendKeys("qaaddress");
                inputCity.SendKeys("qacity");
                inputState.SendKeys("UA");
                inputZIP.SendKeys("123456");
                cbbxCountry.Click();
                cbbxCountry.SendKeys("Albania");
                inputEmail.SendKeys("auto@test.io");
                inputPhone.SendKeys("1234567890");
                inputNote.SendKeys("qanotes");

                

                return this;
            }
        }

        [AllureStep("Press Confirm button for client info")]
        public ClientInfo PressConfirmButtonForClientInfo()
        {
            WaitUntil.ElementIsVisible(_btnConfirmCustomerInfo, 40); // Should remover timeout
            btnConfirmCustomerInfo.Click();
            return this;
        }


        [AllureStep("Fill client info")]
        public ClientInfo FillClientInfoVWR()
        {
            WaitUntil.ElementIsVisible(_inputFirstNameVWR, 45);
            if (inputFirstNameVWR.Text != "")
            {
                return this;
            }
            else
            {
                inputFirstNameVWR.SendKeys("qafirstnameqa");
                inputLastNameVWR.SendKeys("qalastname");
                inputAddressVWR.SendKeys("qaaddress");
                inputCityVWR.SendKeys("qacity");
                inputStateVWR.SendKeys("UA");
                inputZIPVWR.SendKeys("123456");
                cbbxCountryVWR.Click();
                cbbxCountryVWR.SendKeys("Albania");
                inputEmailVWR.SendKeys("auto@test.io");
                inputPhoneVWR.SendKeys("1234567890");
                inputNoteVWR.SendKeys("qanotes");

                return this;
            }
        }
    }
}
