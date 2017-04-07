using CodeWarsSolutions.SevenKyu;
using NUnit.Framework;

namespace CodeWarsSolutions.Test.SevenKyu
{
    [TestFixture]
    class TimeAndSpaceTests
    {
        [Test]
        public void TimeAndSpaceBasicTests()
        {
            var kata = new TimeAndSpace();

            Assert.AreEqual(new bool[] { false, false, true }, kata.MomentOfTimeInSpace("12:30 am"));
            Assert.AreEqual(new bool[] { false, true, false }, kata.MomentOfTimeInSpace("12:02 pm"));
            Assert.AreEqual(new bool[] { true, false, false }, kata.MomentOfTimeInSpace("01:00 pm"));
            Assert.AreEqual(new bool[] { false, false, true }, kata.MomentOfTimeInSpace("11:12 am"));
            Assert.AreEqual(new bool[] { false, false, true }, kata.MomentOfTimeInSpace("05:20 pm"));
            Assert.AreEqual(new bool[] { false, true, false }, kata.MomentOfTimeInSpace("04:20 am"));
        }
    }
}
