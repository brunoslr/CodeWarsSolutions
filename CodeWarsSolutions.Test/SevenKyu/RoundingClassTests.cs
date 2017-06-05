using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;

namespace CodeWarsSolutions.Test.SevenKyu
{

    [TestFixture]
    class RoundingClassTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new RoundingClass();

            Assert.AreEqual(21, kata.Rounding(20, 3));

            Assert.AreEqual(18, kata.Rounding(19, 3));

            Assert.AreEqual(0, kata.Rounding(1, 10));

            Assert.AreEqual(50, kata.Rounding(50, 100));

            Assert.AreEqual(0, kata.Rounding(123, 456));

        }

    }
}
