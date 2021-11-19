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

namespace CC.Tests 
{
    class AdminTests : BaseClassAdmin
    {
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Vladyslav Rybalka")]
        [AllureSuite("CC")]
        [AllureSubSuite("Admin")]
        [Test]
        public void UploadEcuBinaries()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginAdminCC)
                .EnterPassword(Credentials.PasswordAdminCC)
                .PressLoginButton();
            Pages.Navigation
                .GoToBinaryUpload()
                .SelectBaseBinary(BinariesPuth.BaseEcu)
                .ChangeBinaryLabel(CompanyFilter.CC)
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
        [AllureSuite("CC")]
        [AllureSubSuite("Admin")]
        [Test]
        public void UploadTcuBinaries()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginAdminCC)
                .EnterPassword(Credentials.PasswordAdminCC)
                .PressLoginButton();
            Pages.Navigation
                .GoToBinaryUpload()
                .SelectBaseBinary(BinariesPuth.BaseTcu)
                .ChangeBinaryLabel(CompanyFilter.CC)
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
        [AllureSuite("CC")]
        [AllureSubSuite("Admin")]
        [Test]
        public void EditAndRemoveBinaries()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginAdminCC)
                .EnterPassword(Credentials.PasswordAdminCC)
                .PressLoginButton();
            Pages.Navigation
                .GoToBinaryUpload()
                .SelectBaseBinary(BinariesPuth.BaseTcu)
                .ChangeBinaryLabel(CompanyFilter.CC)
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
                .BrowsePerformanceBinary(BinariesPuth.PerformanceTcu)
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
        [AllureSuite("CC")]
        [AllureSubSuite("Admin")]
        [Test]
        public void CheckFlashHistory()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginAdminCC)
                .EnterPassword(Credentials.PasswordAdminCC)
                .PressLoginButton();
            Pages.Navigation
                .GoToFlashHistory()
                .ChangeStartDate()
                .SelectDistributor(Distributors.CC)
                .PressGetReportButton()
                .CompareFlashHistory(new AppDbContext().GetDistributorId(Distributors.CC));


        }
    }
}
