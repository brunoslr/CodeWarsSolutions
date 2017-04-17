using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;

namespace CodeWarsSolutions.Test.SevenKyu
{


    [TestFixture]
    public class PhoneCallKataTests
    {

        [Test]
        public void TestCase()
        {
            var kata = new PhoneCallKata();

            Assert.AreEqual(14, kata.PhoneCall(3, 1, 2, 20), "");

            Assert.AreEqual(1, kata.PhoneCall(2, 2, 1, 2), "");

            Assert.AreEqual(11, kata.PhoneCall(10, 1, 2, 22), "");

            Assert.AreEqual(14, kata.PhoneCall(2, 2, 1, 24), "");

            Assert.AreEqual(3, kata.PhoneCall(1, 2, 1, 6), "");

        }
    }
}
