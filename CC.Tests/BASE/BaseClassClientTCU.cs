using AutomatedProjectEPS.ClassHelpers;
using NUnit.Framework;

namespace CC.Tests
{
    class BaseClassClientTCU : BaseClient
    {
        [SetUp]
        public void Initialize() => Browser.Initialize(AppsPuth.ClientCC);

        [OneTimeSetUp]
        public void OneTimeSetUp() => OneTimeSetUpBase(ControllerName.TCU);

    }
}
