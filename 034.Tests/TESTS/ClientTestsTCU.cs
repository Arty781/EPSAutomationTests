﻿using _034.Tests.BASE;
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
        [AllureOwner("Sukharevsky Artem")]
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

            /*string binaryName = new AppDbContext()
                .GetLastBinary(BinaryPartNumbers.TCU, 5);*/

            Pages.Common
                .PressNextButton();
            Pages.Calibration
                .SelectBinaryJHM034()
                .SelectCalibrationJHM034(BinaryType.Base);
            Pages.Common
                .PressNextButton();
            Pages.ClientInfo
                .FillClientInfo();
            Pages.Common
                .PressNextButton();
            Pages.Flash
                .PressFlashButton();
            Pages.Common
                .CloseProgressBarAfterFlashing();
            Pages.Flash
                .CheckSuccessFlashing034()
                .PressNewFlashButton();
        }


        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Sukharevsky Artem")]
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

            /*string binaryName = new AppDbContext()
                .GetLastBinary(BinaryPartNumbers.TCU, 5);*/

            Pages.Common
                .PressNextButton();
            Pages.Calibration
                .SelectBinaryJHM034()
                .SelectCalibrationJHM034(BinaryType.Performance);
            Pages.Common
                .PressNextButton();
            Pages.ClientInfo
                .FillClientInfo();
            Pages.Common
                .PressNextButton();
            Pages.Flash
                .PressFlashButton();
            Pages.Common
                .CloseProgressBarAfterFlashing();
            Pages.Flash
                .CheckSuccessFlashing034()
                .PressNewFlashButton();
        }
    }
}
