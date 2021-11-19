using AutomatedProjectEPS.ClassHelpers;
using NUnit.Allure.Core;
using NUnit.Framework;
using System.Diagnostics;

namespace SRT.Tests
{
    class BaseClassClientECU : BaseClient
    {
        [SetUp]
        public void Initialize() => Browser.Initialize(AppsPuth.ClientSRT);

        [OneTimeSetUp]
        public void OneTimeSetUp() => OneTimeSetUpBase(ControllerName.ECU);


    }
}