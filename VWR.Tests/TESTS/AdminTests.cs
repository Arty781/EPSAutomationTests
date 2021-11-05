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

namespace VWR.Tests
{
    class AdminTests : BaseClassAdmin
    {
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("VWR")]
        [AllureSubSuite("Admin")]
        [Test]
        public void UploadEcuBinaries()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientVWR)
                .EnterPassword(Credentials.PasswordClientVWR)
                .PressLoginButton();
            Pages.Navigation
                .GoToBinaryUpload()
                .SelectBaseBinary(BinariesPuth.BaseSimos084)
                .ChangeBinaryLabel()
                .SelectPrice()
                .SelectPerformanceBinary(BinariesPuth.PerformanceSimos084)
                .PressAddButton()
                .UploadBinary();
            Pages.Common
                .PressEnterKey();
            string binaryLabel = Pages.BinaryUpload.GetBinaryLabel();
            Pages.Navigation
                .GoToBinarySearch()
                .SearchBinary(binaryLabel)
                .MakeSureBinaryFound(binaryLabel);
        }

        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("VWR")]
        [AllureSubSuite("Admin")]
        [Test]
        public void UploadTcuBinaries()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientVWR)
                .EnterPassword(Credentials.PasswordClientVWR)
                .PressLoginButton();
            Pages.Navigation
                .GoToBinaryUpload()
                .SelectBaseBinary(BinariesPuth.BaseAisinAL1000)
                .ChangeBinaryLabel()
                .SelectPrice()
                .SelectPerformanceBinary(BinariesPuth.PerformanceAisinAL1000)
                .PressAddButton()
                .UploadBinary();
            Pages.Common
                .PressEnterKey();
            string binaryLabel = Pages.BinaryUpload.GetBinaryLabel();
            Pages.Navigation
                .GoToBinarySearch()
                .SearchBinary(binaryLabel)
                .MakeSureBinaryFound(binaryLabel);
        }
    }
}
