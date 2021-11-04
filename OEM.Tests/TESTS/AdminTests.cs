/*using Allure.Commons;
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
        public void UploadBaseBinary()
        {
            Pages.Login
                .Admin(Credentials.LoginClientOEM)
                .AdminPass(Credentials.PasswordClientOEM)
                .LogAdmin();
            *//*Pages.Navigation
                .GoToBinaryUpload()
                .SelectBaseBinary(BinariesPuth.BaseSimos084)
                .ChangeBinaryLabel()
                .SelectPrice()*//*
            Pages.BinaryUpload
                .UploadBinary();
            Pages.Common
                .PressEnterKey();

            string binaryName =
                new AppDbContext().GetLastBinary();

            Pages.Navigation
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
                .VerifyRemovedBinary(binaryName);



        }
    }
}
*/