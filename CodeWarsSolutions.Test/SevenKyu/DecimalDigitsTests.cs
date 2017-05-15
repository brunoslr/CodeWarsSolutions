using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;

namespace CodeWarsSolutions.Test.SevenKyu
{
    [TestFixture]
    public class DecimalDigitsTests
    {
        [Test]
        public void Digits()
        {
            Assert.AreEqual(DecimalDigits.Digits(5ul), 1);
            Assert.AreEqual(DecimalDigits.Digits(12345ul), 5);
            Assert.AreEqual(DecimalDigits.Digits(9876543210ul), 10);
        }
    }
}
