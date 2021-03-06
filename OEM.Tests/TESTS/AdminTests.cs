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
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Admin")]
        [Test]
        public void UploadEcuBinaries()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginAdminOEM)
                .EnterPassword(Credentials.PasswordAdminOEM)
                .PressLoginButton();
            Pages.Navigation
                .GoToBinaryUpload()
                .SelectBaseBinary(BinariesPuth.BaseEcu)
                .ChangeBinaryLabel(CompanyFilter.OEM)
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
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Admin")]
        [Test]
        public void UploadTcuBinaries()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginAdminOEM)
                .EnterPassword(Credentials.PasswordAdminOEM)
                .PressLoginButton();
            Pages.Navigation
                .GoToBinaryUpload()
                .SelectBaseBinary(BinariesPuth.BaseTcu)
                .ChangeBinaryLabel(CompanyFilter.OEM)
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
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Admin")]
        [Test]
        public void EditAndRemoveBinaries()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginAdminOEM)
                .EnterPassword(Credentials.PasswordAdminOEM)
                .PressLoginButton();
            Pages.Navigation
                .GoToBinaryUpload()
                .SelectBaseBinary(BinariesPuth.BaseTcu)
                .ChangeBinaryLabel(CompanyFilter.OEM)
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
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Admin")]
        [Test]
        public void CheckFlashHistory()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginAdminOEM)
                .EnterPassword(Credentials.PasswordAdminOEM)
                .PressLoginButton();
            Pages.Navigation
                .GoToFlashHistory()
                .ChangeStartDate()
                .SelectDistributor(Distributors.OEM)
                .PressGetReportButton(Distributors.OEM)
                .CheckIsflashingsDisplayed(Distributors.OEM);


        }

        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Admin")]
        [Test]
        public void AddNewUser()
        {
            Pages.Login
                .EnterLogin(Credentials.LoginAdminOEM)
                .EnterPassword(Credentials.PasswordAdminOEM)
                .PressLoginButton();
            Pages.Navigation
                .GoToAccessManagement();
            Pages.Management
                .OpenTree()
                .ScrollDown()
                .PressAddUserBtn()
                .EnterFirstName()
                .EnterLastName()
                .EnterEmail()
                .EnterPhone()
                .EnterFax()
                .EnterAddress()
                .EnterCity()
                .EnterZip()
                .FindCountryInput(Countries.Country)
                .FindRoleInput(Roles.Role)
                .FindUserNameInput(UserData.userName);

            string userNameLabel = Pages.Management.GetUserNameLabel();
            Pages.Management
                .FindPasswordInput(UserData.Password)
                .FindSaveUserBtn();
            Pages.Common
               .PressEnterKey();

            Pages.Management
             .SearchUser(userNameLabel)
             .OpenTree()
             .SelectUser()
             .VerifyCreatedUser(userNameLabel, UserData.FirstName, UserData.LastName);


        }

        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Admin")]
        [Test]
        public void DeleteUser()
        {
            Pages.Login
               .EnterLogin(Credentials.LoginAdminOEM)
               .EnterPassword(Credentials.PasswordAdminOEM)
               .PressLoginButton();
            Pages.Navigation
                .GoToAccessManagement();
            Pages.Management
                .OpenTree()
                .ScrollDown()
                .PressAddUserBtn()
                .EnterFirstName()
                .EnterLastName()
                .EnterEmail()
                .EnterPhone()
                .EnterFax()
                .EnterAddress()
                .EnterCity()
                .EnterZip()
                .FindCountryInput(Countries.Country)
                .FindRoleInput(Roles.Role)
                .FindUserNameInput(UserData.userName);
            string userNameLabel = Pages.Management.GetUserNameLabel();
            Pages.Management
                .FindPasswordInput(UserData.Password)
                .FindSaveUserBtn();
            Pages.Common
               .PressEnterKey();

            Pages.Management
             .SearchUser(userNameLabel)
             .OpenTree()
             .SelectUser()
             .ClickToScroll()
             .ClickDeleteUserBtn();
            Pages.Common
               .PressEnterKey()
               .PressEnterKey();
            /*.VerifyDeleteUser(userNameLabel);*/


        }
    }
}
