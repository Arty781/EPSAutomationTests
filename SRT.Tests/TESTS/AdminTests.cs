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
    class AdminTests : BaseClassAdmin
    {
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("SRT")]
        [AllureSubSuite("Admin")]
        [Test]
        public void UploadEcuBinaries()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginAdminSRT)
                .EnterPassword(Credentials.PasswordAdminSRT)
                .PressLoginButton();
            Pages.Navigation
                .GoToBinaryUpload()
                .SelectBaseBinary(BinariesPuth.BaseEcu)
                .ChangeBinaryLabel(CompanyFilter.SRT)
                .SelectPrice()
                .SelectPerformanceBinary(BinariesPuth.PerformanceEcu)
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
        [AllureSuite("SRT")]
        [AllureSubSuite("Admin")]
        [Test]
        public void UploadTcuBinaries()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginAdminSRT)
                .EnterPassword(Credentials.PasswordAdminSRT)
                .PressLoginButton();
            Pages.Navigation
                .GoToBinaryUpload()
                .SelectBaseBinary(BinariesPuth.BaseTcu)
                .ChangeBinaryLabel(CompanyFilter.SRT)
                .SelectPrice()
                .SelectPerformanceBinary(BinariesPuth.PerformanceTcu)
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
        [AllureSuite("SRT")]
        [AllureSubSuite("Admin")]
        [Test]
        public void EditAndRemoveBinaries()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginAdminSRT)
                .EnterPassword(Credentials.PasswordAdminSRT)
                .PressLoginButton();
            Pages.Navigation
                .GoToBinaryUpload()
                .SelectBaseBinary(BinariesPuth.BaseEcu)
                .ChangeBinaryLabel(CompanyFilter.SRT)
                .SelectPrice()
                .UploadBinary();
            Pages.Common
                .PressEnterKey();
            string binaryLabel = Pages.BinaryUpload.GetBinaryLabel();
            Pages.Navigation
                .GoToBinarySearch()
                .SearchBinary(binaryLabel)
                .SelectBinary()
                .PressEditBinaryButton()
                .BrowsePerformanceBinary(BinariesPuth.PerformanceEcu)
                .PressAddPerfButton()
                .EditBinary();
            Pages.Common
               .PressEnterKey();
            Pages.Navigation
               .GoToBinarySearch()
               .SearchBinary(binaryLabel)
               .SelectBinary()
               .PressRemoveBinaryButton();
            Pages.Common
               .PressEnterKey()
               .VerifyRemovedBinary(binaryLabel);

        }

        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("SRT")]
        [AllureSubSuite("Admin")]
        [Test]
        public void CheckFlashHistory()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginAdminSRT)
                .EnterPassword(Credentials.PasswordAdminSRT)
                .PressLoginButton();
            Pages.Navigation
                .GoToFlashHistory()
                .ChangeStartDate()
                .SelectDistributor(Distributors.SRT)
                .PressGetReportButton()
                .CompareFlashHistory(new AppDbContext().GetDistributorId(Distributors.SRT));


        }
    }
}
