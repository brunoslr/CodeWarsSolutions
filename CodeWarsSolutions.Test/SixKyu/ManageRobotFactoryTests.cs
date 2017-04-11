using CodeWarsSolutions.SixKyu;
using NUnit.Framework;
using System;

namespace CodeWarsSolutions.Test.SixKyu
{
    [TestFixture]
    class ManageRobotFactoryTests
    {
        ManageRobotFactory sut;

        [OneTimeSetUp]
        public void TestSetup()
        {
            sut = new ManageRobotFactory();
        }

        [Test]
        public void RobotFactoryBasicTests()
        {
            Assert.AreEqual(5000, sut.CalculateScrap(new[] { 10 }, 90));
            Assert.AreEqual(3820, sut.CalculateScrap(new[] { 20, 10 }, 55));
        }

    }
}
