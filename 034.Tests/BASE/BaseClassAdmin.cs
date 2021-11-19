using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Diagnostics;

namespace _034.Tests
{
    class BaseClassAdmin : BaseAdmin
    {
        [SetUp]
        public void Initialize() => Browser.Initialize(AppsPuth.Admin034);
    }
}