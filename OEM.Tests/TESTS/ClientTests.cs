using Allure.Commons;
using AutomatedProjectEPS.ClassHelpers;
using AutomatedProjectEPS.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace OEM.Tests
{
    class ClientTests : BaseClassClient
    {
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Client")]
        [Test]
        public void BaseEcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientOEM)
                .EnterPassword(Credentials.PasswordClientOEM)
                .PressLoginButton();
            Pages.Common
                .PressNextButton();
            Pages.Controller
                .SelectEngineController();
            Pages.Common
                .PressNextButton();
            Pages.Controller
                .PressCheckIdButton();

            string binaryName = new AppDbContext()
                .GetLastBinary(Pages.Controller
                .GetControllerInfo(), 10);

            Pages.ClientInfo
                .FillClientInfo()
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
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Client")]
        [Test]
        public void PerformanceEcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientOEM)
                .EnterPassword(Credentials.PasswordClientOEM)
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
                .GetLastBinary(Pages.Controller
                .GetControllerInfo(), 10);

            Pages.ClientInfo
                .FillClientInfo()
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

        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Client")]
        [Test]
        public void BaseTcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientOEM)
                .EnterPassword(Credentials.PasswordClientOEM)
                .PressLoginButton();
            Pages.Common
                .PressNextButton();
            Pages.Controller
                .SelectEngineController();
            Pages.Common
                .PressNextButton();
            Pages.Controller
                .PressCheckIdButton();

            string binaryName = new AppDbContext()
                .GetLastBinary(Pages.Controller
                .GetControllerInfo(), 10);

            Pages.ClientInfo
                .FillClientInfo()
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
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Client")]
        [Test]
        public void PerformanceTcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientOEM)
                .EnterPassword(Credentials.PasswordClientOEM)
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
                .GetLastBinary(Pages.Controller
                .GetControllerInfo(), 10);

            Pages.ClientInfo
                .FillClientInfo()
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


