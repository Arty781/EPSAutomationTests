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
    class ClientTests : BaseClassClient
    {
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("JHM")]
        [AllureSubSuite("Client")]
        [Test]
        public void BaseEcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientJHM)
                .EnterPassword(Credentials.PasswordClientJHM)
                .PressLoginButton()
                .PressCheckIdButton();

            string binaryName = new AppDbContext()
                .GetLastBinary(Pages.Controller
                .GetControllerInfo(), 9);

            Pages.Common
                .PressNextButton();
            Pages.Calibration
                .SelectBinary(binaryName)
                .SelectCalibration(BinaryType.Base);
            Pages.Common
                .PressNextButton()
                .PressNextButton();
            Pages.Flash
                .PressFlashButton()
                .CheckSuccessFlashing()
                .PressNewFlashButton();
        }


        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("JHM")]
        [AllureSubSuite("Client")]
        [Test]
        public void PerformanceEcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientJHM)
                .EnterPassword(Credentials.PasswordClientJHM)
                .PressLoginButton()
                .PressCheckIdButton();

            string binaryName = new AppDbContext()
                .GetLastBinary(Pages.Controller
                .GetControllerInfo(), 9);

            Pages.Common
                .PressNextButton();
            Pages.Calibration
                .SelectBinary(binaryName)
                .SelectCalibration(BinaryType.Performance);
            Pages.Common
                .PressNextButton()
                .PressNextButton();
            Pages.Flash
                .PressFlashButton()
                .CheckSuccessFlashing()
                .PressNewFlashButton();
        }

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
                .EnterPassword(Credentials.PasswordClientJHM)
                .PressLoginButton()
                .SelectTransmissionController()
                .PressCheckIdButton();

            string binaryName = new AppDbContext()
                .GetLastBinary(Pages.Controller
                .GetControllerInfo(), 9);

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
                .CheckSuccessFlashing()
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
                .EnterPassword(Credentials.PasswordClientJHM)
                .PressLoginButton()
                .SelectTransmissionController()
                .PressCheckIdButton();

            string binaryName = new AppDbContext()
                .GetLastBinary(Pages.Controller
                .GetControllerInfo(), 9);

            Pages.Common
                .PressNextButton();
            Pages.Calibration
                .SelectBinary(binaryName)
                .SelectCalibration(BinaryType.Performance);
            Pages.Common
                .PressNextButton()
                .PressNextButton();
            Pages.Flash
                .PressFlashButton()
                .CheckSuccessFlashing()
                .PressNewFlashButton();
        }
    }
}
