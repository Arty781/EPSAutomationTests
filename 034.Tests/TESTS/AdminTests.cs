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

namespace _034.Tests
{
    class AdminTests : BaseClassAdmin
    {
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("034")]
        [AllureSubSuite("Admin")]
        [Test]
        public void UploadBaseAndPerformanceBinaries()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginClient034)
                .EnterPassword(Credentials.PasswordClient034)
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
    }
}
