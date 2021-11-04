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

namespace SRT.Tests 
{
    class ClientTests : BaseClassClient
    {
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("SRT")]
        [AllureSubSuite("Client")]
        [Test]
        public void BaseEcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientSRT)
                .EnterPassword(Credentials.PasswordClientSRT)
                .PressLoginButton()
                .SelectEngineController();
            Pages.Common
                .PressEnterKey();
            Pages.ClientInfo
                //.FillClientInfoVWR()
                .PressConfirmButtonForClientInfo();
            Pages.Common
                .PressEnterKey();

            string binaryName = new AppDbContext()
                .GetLastBinary(BinaryPartNumbers.Simos_8_4, 11);

            Pages.Calibration
                .SelectBinary(binaryName)
                .SelectCalibration(BinaryType.Base)
                .PressConfirmButtonForBinaryInfo();
            Pages.Flash
                .PressFlashButton();
            Pages.Common
                .CloseProgressBar()
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
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("SRT")]
        [AllureSubSuite("Client")]
        [Test]
        public void PerformanceEcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientSRT)
                .EnterPassword(Credentials.PasswordClientSRT)
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
                .GetLastBinary(BinaryPartNumbers.AisinAL991, 11);

            Pages.Calibration
                .SelectBinary(binaryName)
                .SelectCalibration(BinaryType.Performance)
                .PressConfirmButtonForBinaryInfo();
            Pages.Flash
                .PressFlashButton();
            Pages.Common
                .CloseProgressBar()
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
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("SRT")]
        [AllureSubSuite("Client")]
        [Test]
        public void BaseTcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientSRT)
                .EnterPassword(Credentials.PasswordClientSRT)
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
                .GetLastBinary(BinaryPartNumbers.Simos_8_4, 11);

            Pages.Calibration
                .SelectBinary(binaryName)
                .SelectCalibration(BinaryType.Base)
                .PressConfirmButtonForBinaryInfo();
            Pages.Flash
                .PressFlashButton();
            Pages.Common
                .CloseProgressBar()
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
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("SRT")]
        [AllureSubSuite("Client")]
        [Test]
        public void PerformanceTcuFlashing()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientSRT)
                .EnterPassword(Credentials.PasswordClientSRT)
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
                .GetLastBinary(BinaryPartNumbers.AisinAL991, 11);

            Pages.Calibration
                .SelectBinary(binaryName)
                .SelectCalibration(BinaryType.Performance)
                .PressConfirmButtonForBinaryInfo();
            Pages.Flash
                .PressFlashButton();
            Pages.Common
                .CloseProgressBar()
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
