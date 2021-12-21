using Allure.Commons;
using AutomatedProjectEPS.ClassHelpers;
using AutomatedProjectEPS.PageObjects;
using NUnit.Allure.Attributes;
using NUnit.Framework;

namespace JHM.Tests
{
    class ClientTestsECU : BaseClassClientECU
    {
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("JHM")]
        [AllureSubSuite("Client")]
        [Test]
        public void BaseEcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientJHM)
                .EnterPassword(Credentials.PasswordClient)
                .PressLoginButton()
                .PressCheckIdButton();

            string binaryName = new AppDbContext()
                .GetLastBinary(BinaryPartNumbers.ECU, 9);

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
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("JHM")]
        [AllureSubSuite("Client")]
        [Test]
        public void PerformanceEcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientJHM)
                .EnterPassword(Credentials.PasswordClient)
                .PressLoginButton()
                .PressCheckIdButton();

            string binaryName = new AppDbContext()
                .GetLastBinary(BinaryPartNumbers.ECU, 9);

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
