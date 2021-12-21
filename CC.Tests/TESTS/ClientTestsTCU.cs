using Allure.Commons;
using AutomatedProjectEPS.ClassHelpers;
using AutomatedProjectEPS.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace CC.Tests
{
    class ClientTestsTCU : BaseClassClientTCU
    {
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("СС")]
        [AllureSubSuite("Client")]
        [Test]
        public void BaseTcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientCC)
                .EnterPassword(Credentials.PasswordClient)
                .PressLoginButton()
                .SelectTransmissionController();
            Pages.Common
                .PressEnterKey();
            Pages.ClientInfo
                .FillClientInfoVWR()
                .PressConfirmButtonForClientInfo();
            Pages.Common
                .PressEnterKey();

            string binaryName = new AppDbContext()
                .GetLastBinary(BinaryPartNumbers.TCU, 2);

            Pages.Calibration
                .SelectBinary(binaryName)
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
        public void PerformanceTcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientCC)
                .EnterPassword(Credentials.PasswordClient)
                .PressLoginButton()
                .SelectTransmissionController();
            Pages.Common
                .PressEnterKey();
            Pages.ClientInfo
                .FillClientInfoVWR()
                .PressConfirmButtonForClientInfo();
            Pages.Common
                .PressEnterKey();

            string binaryName = new AppDbContext()
                .GetLastBinary(BinaryPartNumbers.TCU, 2);

            Pages.Calibration
                .SelectBinary(binaryName)
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
