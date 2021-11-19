using AutomatedProjectEPS.ClassHelpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEM.Tests
{
    class BaseClassClientTCU : BaseClient
    {
        [SetUp]
        public void Initialize() => Browser.Initialize(AppsPuth.ClientOEM);

        [OneTimeSetUp]
        public void OneTimeSetUp() => OneTimeSetUpBase(ControllerName.TCU);

    }
}
