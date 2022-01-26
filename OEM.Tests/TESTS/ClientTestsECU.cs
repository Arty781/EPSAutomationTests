using Allure.Commons;
using AutomatedProjectEPS.ClassHelpers;
using AutomatedProjectEPS.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace OEM.Tests
{
    class ClientTestsECU : BaseClassClientECU
    {
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Client")]
        [Test]
        public void BaseEcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientOEM)
                .EnterPassword(Credentials.PasswordClient)
                .PressLoginButton();
            Pages.Common
                .PressNextButton();
            Pages.Controller
                .SelectEngineController();
            Pages.Common
                .PressNextButton();
            Pages.Controller
                .PressCheckIdButton();

           /* string binaryName = new AppDbContext()
                .GetLastBinary(BinaryPartNumbers.ECU, 10);*/

            Pages.ClientInfo
                .FillClientInfoOEM()
                .PressConfirmButtonForClientInfo();
            Pages.Common
                .PressEnterKey()
                .PressNextButton();
            Pages.Calibration
                .SelectBinaryOEM();
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
        public void PerformanceEcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientOEM)
                .EnterPassword(Credentials.PasswordClient)
                .PressLoginButton();
            Pages.Common
                .PressNextButton();
            Pages.Controller
                .SelectEngineController();
            Pages.Common
                .PressNextButton();
            Pages.Controller
                .PressCheckIdButton();

            /*string binaryName = new AppDbContext()
                .GetLastBinary(BinaryPartNumbers.ECU, 10);*/

            Pages.ClientInfo
                .FillClientInfoOEM()
                .PressConfirmButtonForClientInfo();
            Pages.Common
                .PressEnterKey()
                .PressNextButton();
            Pages.Calibration
                .SelectBinaryOEM();
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


