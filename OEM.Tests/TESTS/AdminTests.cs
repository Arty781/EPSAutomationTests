﻿using Allure.Commons;
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
                .SelectServer(Servers.Server)
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
                .SelectServer(Servers.Server)
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
                .SelectServer(Servers.Server)
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
               .PressEnterKey();
            Pages.BinarySearch
                .MakeSureBinaryDeleted(binaryLabel);
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
                .SelectServer(Servers.Server)
                .EnterLogin(Credentials.LoginAdminOEM)
                .EnterPassword(Credentials.PasswordAdminOEM)
                .PressLoginButton();
            Pages.Navigation
                .GoToFlashHistory()
                .ChangeStartDate()
                .SelectDistributor(Distributors.OEM)
                .PressGetReportButton()
                .CheckIsflashingsDisplayed(Distributors.OEM);


        }

        #region AddNewUserInRootDealer
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Admin")]
        [Test]
        public void AddNewUserInRootDealer()
        {
            Pages.Login
                .SelectServer(Servers.Server)
                .EnterLogin(Credentials.LoginAdminOEM)
                .EnterPassword(Credentials.PasswordAdminOEM)
                .PressLoginButton();
            Pages.Navigation
                .GoToAccessManagement();
            Pages.Management
                .OpenRootTree()
                .PressAddUserBtn()
                .EnterUserData()
                .ActivateUser()
                .OpenUserNotesModal()
                .AddUserNotes()
                .AddMultipleFilters(CompanyFilter.OEM)
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
             .OpenNestedTree()
             .SelectUser()
             .VerifyCreatedUser(userNameLabel, UserData.FirstName, UserData.LastName);

        }
        #endregion

        #region DeleteUserOnOEM
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Admin")]
        [Test]
        public void DeleteUserInRootDealer()
        {
            Pages.Login
                .SelectServer(Servers.Server)
              .EnterLogin(Credentials.LoginAdminOEM)
              .EnterPassword(Credentials.PasswordAdminOEM)
              .PressLoginButton();
            Pages.Navigation
                .GoToAccessManagement();
            Pages.Management
                .OpenRootTree()
                .PressAddUserBtn()
                .EnterUserData()
                .AddMultipleFilters(CompanyFilter.OEM)
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
             .OpenNestedTree()
             .SelectUser()
             .ClickDeleteUserBtn();
            Pages.Common
               .PressEnterKey()
               .PressEnterKey();
            Pages.Management
            .SearchUser(userNameLabel)
            .VerifyDeleteUser(userNameLabel);


        }
        #endregion

        #region AddNewRootDealer
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Admin")]
        [Test]
        public void AddNewRootDealer()
        {
            Pages.Login
                .SelectServer(Servers.Server)
                .EnterLogin(Credentials.LoginAdminOEM)
                .EnterPassword(Credentials.PasswordAdminOEM)
                .PressLoginButton();
            Pages.Navigation
                .GoToAccessManagement();
            Pages.Management
                .OpenRootTree()
                .ScrollDown()
                .PressAddDealerBtn()
                .EnterRootDealerData(Distributors.OEM)
                .ActivateDealer()
                .OpenDealerNotesModal()
                .AddDealerNotes()
                .SelectRegion()
                .AddMultipleFilters(CompanyFilter.OEM)
                .FindCountryInput(Countries.Country)
                .ClickSaveDealerBtn();

            string dealerNameLabel = Pages.Management.GetCompanyLabel();

            Pages.Common
               .PressEnterKey();
            Pages.Management
             .SearchUser(dealerNameLabel)
             .OpenNestedTree()
             .VerifyCreatedRootDealer(dealerNameLabel);

        }
        #endregion

        #region AddNewNestedDealer
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Admin")]
        [Test]
        public void AddNewNestedDealer()
        {
            Pages.Login
                .SelectServer(Servers.Server)
                .EnterLogin(Credentials.LoginAdminOEM)
                .EnterPassword(Credentials.PasswordAdminOEM)
                .PressLoginButton();
            Pages.Navigation
                .GoToAccessManagement();
            Pages.Management
                .SearchUser(Distributors.OEM)
                .OpenNestedTree()
                .PressAddDealerBtn()
                .EnterNestedDealerData()
                .ActivateDealer()
                .OpenDealerNotesModal()
                .AddDealerNotes()
                .SelectRegion()
                .AddMultipleFilters(CompanyFilter.OEM)
                .FindCountryInput(Countries.Country)
                .ClickSaveDealerBtn();

            string dealerNameLabel = Pages.Management.GetCompanyLabel();

            Pages.Common
               .PressEnterKey();
            Pages.Management
             .SearchUser(dealerNameLabel)
             .OpenNestedTree()
             .VerifyCreatedDealer(dealerNameLabel);

        }
        #endregion

        #region EditNewNestedDealer
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Admin")]
        [Test]
        public void EditNestedDealer()
        {
            Pages.Login
                .SelectServer(Servers.Server)
                .EnterLogin(Credentials.LoginAdminOEM)
                .EnterPassword(Credentials.PasswordAdminOEM)
                .PressLoginButton();
            Pages.Navigation
                .GoToAccessManagement();
            Pages.Management
                .SearchUser(Distributors.OEM)
                .OpenNestedTree()
                .PressAddDealerBtn()
                .EnterNestedDealerData()
                .ActivateDealer()
                .OpenDealerNotesModal()
                .AddDealerNotes()
                .SelectRegion()
                .AddMultipleFilters(CompanyFilter.OEM)
                .FindCountryInput(Countries.Country)
                .ClickSaveDealerBtn();

            string dealerNameLabel = Pages.Management.GetCompanyLabel();

            Pages.Common
               .PressEnterKey();
            Pages.Management
             .SearchUser(dealerNameLabel)
             .OpenNestedTree()
             .SelectDealer()
             .EditDealerData()
             .ActivateDealer()
             .OpenDealerNotesModal()
             .AddDealerNotes()
             .RemoveFilters();
            string editedDealerNameLabel = Pages.Management.GetCompanyLabel();
            Pages.Management
             .ClickSaveDealerBtn();
            Pages.Common
               .PressEnterKey();
            Pages.Management
             .SearchUser(editedDealerNameLabel)
             .OpenNestedTree()
             .SelectDealer()
             .VerifyEditedDealer(editedDealerNameLabel);

        }
        #endregion

        #region EditNestedUser
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Admin")]
        [Test]
        public void EditNestedUser()
        {
            Pages.Login
                .SelectServer(Servers.Server)
              .EnterLogin(Credentials.LoginAdminOEM)
              .EnterPassword(Credentials.PasswordAdminOEM)
              .PressLoginButton();
            Pages.Navigation
                .GoToAccessManagement();
            Pages.Management
                .SearchUser(Distributors.OEM)
                .OpenNestedTree()
                .PressAddUserBtn()
                .EnterUserData()
                .AddMultipleFilters(CompanyFilter.OEM)
                .FindCountryInput(Countries.Country)
                .FindRoleInput(Roles.Role)
                .FindUserNameInput(UserData.userName);

            string userNameLabel = Pages.Management.GetUserNameLabel();
            Pages.Management
                .FindPasswordInput(UserData.Password)
                .FindSaveUserBtn()
                .VerifyUserSavedPopUp();
            Pages.Common
               .PressEnterKey();

            Pages.Management
                .SearchUser(userNameLabel)
                .OpenNestedTree()
                .SelectUser()
                .EditUserData()
                .RemoveFilters()
                .FindCountryInput("Georgia")
                .FindRoleInput("SearchOnly");
            string firstName = Pages.Management.GetUserFirstName();
            Pages.Management
                .FindSaveUserBtn()
                .VerifyUserEditedPopUp();
            Pages.Common
               .PressEnterKey();
            Pages.Management
             .SearchUser(userNameLabel)
             .OpenNestedTree()
             .SelectUser()
             .VerifyUserEdited(firstName);

        }
        #endregion

        #region DeleteNestedUser
        [AllureTag("Regression")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Sukharevsky Artem")]
        [AllureSuite("OEM")]
        [AllureSubSuite("Admin")]
        [Test]
        public void DeleteNestedUser()
        {
            Pages.Login
                .SelectServer(Servers.Server)
              .EnterLogin(Credentials.LoginAdminOEM)
              .EnterPassword(Credentials.PasswordAdminOEM)
              .PressLoginButton();
            Pages.Navigation
                .GoToAccessManagement();
            Pages.Management
                .SearchUser(Distributors.OEM)
                .OpenNestedTree()
                .PressAddUserBtn()
                .EnterUserData()
                .AddMultipleFilters(CompanyFilter.OEM)
                .FindCountryInput(Countries.Country)
                .FindRoleInput(Roles.Role)
                .FindUserNameInput(UserData.userName);

            string userNameLabel = Pages.Management.GetUserNameLabel();
            Pages.Management
                .FindPasswordInput(UserData.Password)
                .FindSaveUserBtn()
                .VerifyUserSavedPopUp();
            Pages.Common
               .PressEnterKey();

            Pages.Management
             .SearchUser(userNameLabel)
             .OpenNestedTree()
             .SelectUser()
             .ClickDeleteUserBtn()
             .VerifyDeletedConfirmationPopUp();
            Pages.Common
               .PressEnterKey();
            Pages.Management
                .VerifyDeletedUserPopUp(userNameLabel);
            Pages.Common
               .PressEnterKey();
            Pages.Management
            .SearchUser(userNameLabel)
            .VerifyDeleteUser(userNameLabel);


        }
        #endregion
    }
}
