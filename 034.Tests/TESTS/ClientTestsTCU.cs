using _034.Tests.BASE;
using Allure.Commons;
using AutomatedProjectEPS.ClassHelpers;
using AutomatedProjectEPS.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace _034.Tests
{
    class ClientTestsTCU : BaseClassClientTCU
    {
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("034")]
        [AllureSubSuite("Client")]
        [Test]
        public void BaseTcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClient034)
                .EnterPassword(Credentials.PasswordClient)
                .PressLoginButton()
                .SelectTransmissionController()
                .PressCheckIdButton();

            string binaryName = new AppDbContext()
                .GetLastBinary(BinaryPartNumbers.TCU, 5);

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
                .CheckSuccessFlashing034()
                .PressNewFlashButton();
        }


        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("034")]
        [AllureSubSuite("Client")]
        [Test]
        public void PerformanceTcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClient034)
                .EnterPassword(Credentials.PasswordClient)
                .PressLoginButton()
                .SelectTransmissionController()
                .PressCheckIdButton();

            string binaryName = new AppDbContext()
                .GetLastBinary(BinaryPartNumbers.TCU, 5);

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
                .CheckSuccessFlashing034()
                .PressNewFlashButton();
        }
    }
}
