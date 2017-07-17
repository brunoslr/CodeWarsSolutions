
namespace CodeWarsSolutions.Test.SevenKyu
{
    using System;
    using NUnit.Framework;
    using CodeWarsSolutions.SevenKyu;

    [TestFixture]
    public class DivSevenTests
    {

        [Test]
        public void DivSevenTest1()
        {
            Assert.AreEqual(new long[] { 7, 2 }, DivSeven.Seven(1603));
            Assert.AreEqual(new long[] { 35, 1 }, DivSeven.Seven(371));
            Assert.AreEqual(new long[] { 42, 1 }, DivSeven.Seven(483));
        }
    }
}
