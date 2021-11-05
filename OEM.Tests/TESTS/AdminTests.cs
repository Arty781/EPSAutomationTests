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

namespace OEM.Tests
{
    [TestFixture]
    class AdminTests : BaseClassAdmin
    {
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Admin")]
        [Test]
        public void UploadBaseAndPerformanceBinaries()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClientOEM)
                .EnterPassword(Credentials.PasswordClientOEM)
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






        /*Pages.Navigation
                .GoToBinarySearch()
                .SearchBinary(binaryName)
                .SelectBinary()
                .PressEditBinaryButton()
                .SelectPerformanceBinary(BinariesPuth.PerformanceSimos084)
                .PressAddButton()
                .PressEditButton();
            Pages.Common
                .PressEnterKey();
            Pages.Navigation
                .GoToBinarySearch()
                .SearchBinary(binaryName)
                .SelectBinary()
                .PressRemoveBinaryButton();
            Pages.Common
                .PressEnterKey()
                .VerifyRemovedBinary(binaryName);*/
    }
}
