using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Diagnostics;

namespace CC.Tests
{
    class BaseClassAdmin : BaseAdmin
    {
        [SetUp]
        public void Initialize() => Browser.Initialize(AppsPuth.AdminCC);
    }
}