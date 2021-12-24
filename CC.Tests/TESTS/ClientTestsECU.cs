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

namespace CC.Tests
{
    class ClientTestsECU : BaseClassClientECU
    {
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("СС")]
        [AllureSubSuite("Client")]
        [Test]
        public void BaseEcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientCC)
                .EnterPassword(Credentials.PasswordClient)
                .PressLoginButton()
                .SelectEngineController();
            Pages.Common
                .PressEnterKey();
            Pages.ClientInfo
                .FillClientInfoVWR()
                .PressConfirmButtonForClientInfo();
            Pages.Common
                .PressEnterKey();

            string binaryName = new AppDbContext()
                .GetLastBinary(BinaryPartNumbers.ECU, 2);

            Pages.Calibration
                .SelectBinary()
                .SelectCalibration(BinaryType.Base)
                .PressConfirmButtonForBinaryInfo();
            Pages.Flash
                .PressFlashButton();
            Pages.Common
                .CloseProgressBarAfterFlashing()
                .WaitFifteenSeconds()
                .CloseMessageBox()
                .CloseProgressBar()
                .CloseProgressBar()
                .SwitchWindow();
            Pages.Flash
                .CheckSuccessFlashingLogs();

        }

        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("СС")]
        [AllureSubSuite("Client")]
        [Test]
        public void PerformanceEcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientCC)
                .EnterPassword(Credentials.PasswordClient)
                .PressLoginButton()
                .SelectEngineController();
            Pages.Common
                .PressEnterKey();
            Pages.ClientInfo
                .FillClientInfoVWR()
                .PressConfirmButtonForClientInfo();
            Pages.Common
                .PressEnterKey();

            string binaryName = new AppDbContext()
                .GetLastBinary(BinaryPartNumbers.ECU, 2);

            Pages.Calibration
                .SelectBinary()
                .SelectCalibration(BinaryType.Performance)
                .PressConfirmButtonForBinaryInfo();
            Pages.Flash
                .PressFlashButton();
            Pages.Common
                .CloseProgressBarAfterFlashing()
                .WaitFifteenSeconds()
                .CloseMessageBox()
                .CloseProgressBar()
                .CloseProgressBar()
                .SwitchWindow();
            Pages.Flash
                .CheckSuccessFlashingLogs();
        }



    }
}
