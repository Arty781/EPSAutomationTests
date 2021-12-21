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

namespace OEM.Tests
{
    class ClientTestsTCU : BaseClassClientTCU
    {
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Client")]
        [Test]
        public void BaseTcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientOEM)
                .EnterPassword(Credentials.PasswordClient)
                .PressLoginButton();
            Pages.Common
                .PressNextButton();
            Pages.Controller
                .SelectTransmissionController();
            Pages.Common
                .PressNextButton();
            Pages.Controller
                .PressCheckIdButton();

            string binaryName = new AppDbContext()
                .GetLastBinary(BinaryPartNumbers.TCU, 10);

            Pages.ClientInfo
                .FillClientInfoOEM()
                .PressConfirmButtonForClientInfo();
            Pages.Common
                .PressEnterKey()
                .PressNextButton();
            Pages.Calibration
                .SelectBinaryOEM(binaryName);
            Pages.Common
                .PressNextButton();
            Pages.Calibration
                .SelectCalibrationOEM(BinaryType.Base);
            Pages.Common
                .PressNextButton();
            Pages.Calibration
                .PressCalibrateButton();
            Pages.Common
                .PressNextButton();
            Pages.Flash
                .PressFlashButton();
            Pages.Common
                .CloseProgressBarAfterFlashing()
                .WaitFifteenSeconds()
                .CloseMessageBox()
                .CloseProgressBar()
                .CloseProgressBar()
                .SwitchWindow()
                .PressNextButton();
        }

        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Client")]
        [Test]
        public void PerformanceTcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientOEM)
                .EnterPassword(Credentials.PasswordClient)
                .PressLoginButton();
            Pages.Common
                .PressNextButton();
            Pages.Controller
                .SelectTransmissionController();
            Pages.Common
                .PressNextButton();
            Pages.Controller
                .PressCheckIdButton();

            string binaryName = new AppDbContext()
                .GetLastBinary(BinaryPartNumbers.TCU, 10);

            Pages.ClientInfo
                .FillClientInfoOEM()
                .PressConfirmButtonForClientInfo();
            Pages.Common
                .PressEnterKey()
                .PressNextButton();
            Pages.Calibration
                .SelectBinaryOEM(binaryName);
            Pages.Common
                .PressNextButton();
            Pages.Calibration
                .SelectCalibrationOEM(BinaryType.Performance);
            Pages.Common
                .PressNextButton();
            Pages.Calibration
                .PressCalibrateButton();
            Pages.Common
                .PressNextButton();
            Pages.Flash
                .PressFlashButton();
            Pages.Common
                .CloseProgressBarAfterFlashing()
                .WaitFifteenSeconds()
                .CloseMessageBox()
                .CloseProgressBar()
                .CloseProgressBar()
                .SwitchWindow()
                .PressNextButton();
        }

    }
}
