using Allure.Commons;
using AutomatedProjectEPS.ClassHelpers;
using AutomatedProjectEPS.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace _034.Tests
{
    class ClientTestsECU : BaseClassClientECU
    {

        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("034")]
        [AllureSubSuite("Client")]
        [Test]
        public void BaseEcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClient034)
                .EnterPassword(Credentials.PasswordClient)
                .PressLoginButton()
                .PressCheckIdButton();

            string binaryName = new AppDbContext()
                .GetLastBinary(BinaryPartNumbers.ECU, 5);

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
        public void PerformanceEcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClient034)
                .EnterPassword(Credentials.PasswordClient)
                .PressLoginButton()
                .PressCheckIdButton();

            string binaryName = new AppDbContext()
                .GetLastBinary(BinaryPartNumbers.ECU, 5);

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
