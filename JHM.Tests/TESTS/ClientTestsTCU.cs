using Allure.Commons;
using AutomatedProjectEPS.ClassHelpers;
using AutomatedProjectEPS.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHM.Tests
{
    class ClientTestsTCU : BaseClassClientTCU
    {
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("JHM")]
        [AllureSubSuite("Client")]
        [Test]
        public void BaseTcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientJHM)
                .EnterPassword(Credentials.PasswordClient)
                .PressLoginButton()
                .SelectTransmissionController()
                .PressCheckIdButton();

            string binaryName = new AppDbContext()
                .GetLastBinary(BinaryPartNumbers.TCU, 9);

            Pages.Common
                .PressNextButton();
            Pages.Calibration
                .SelectBinary(binaryName)
                .SelectCalibration(BinaryType.Base);
            Pages.Common
                .PressNextButton();
            Pages.ClientInfo
                .FillClientInfo();
            Pages.Common
                .PressNextButton();
            Pages.Flash
                .PressFlashButton()
                .CheckSuccessFlashingJHM()
                .PressNewFlashButton();
        }


        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("JHM")]
        [AllureSubSuite("Client")]
        [Test]
        public void PerformanceTcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientJHM)
                .EnterPassword(Credentials.PasswordClient)
                .PressLoginButton()
                .SelectTransmissionController()
                .PressCheckIdButton();

            string binaryName = new AppDbContext()
                .GetLastBinary(BinaryPartNumbers.TCU, 9);

            Pages.Common
                .PressNextButton();
            Pages.Calibration
                .SelectBinary(binaryName)
                .SelectCalibration(BinaryType.Performance);
            Pages.Common
                .PressNextButton();
            Pages.ClientInfo
               .FillClientInfo();
            Pages.Common
                .PressNextButton();
            Pages.Flash
                .PressFlashButton()
                .CheckSuccessFlashingJHM()
                .PressNewFlashButton();
        }
    }
}
