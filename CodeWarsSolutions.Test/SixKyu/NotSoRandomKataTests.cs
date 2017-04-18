using CodeWarsSolutions.SixKyu;
using NUnit.Framework;

namespace CodeWarsSolutions.Test.SixKyu
{
    [TestFixture]
    public class NotSoRandomKataTests
    {
    
        [Test]
        public void BasicTests()
        {
            var kata = new NotSoRandomKata();

            Assert.AreEqual("Black", kata.NotSoRandom(1, 1));

            Assert.AreEqual("White", kata.NotSoRandom(2, 1));

            Assert.AreEqual("Black", kata.NotSoRandom(1, 2));

            Assert.AreEqual("White", kata.NotSoRandom(2, 2));

            Assert.AreEqual("White", kata.NotSoRandom(6, 9));

            Assert.AreEqual("White", kata.NotSoRandom(10000, 10000));

            Assert.AreEqual("Black", kata.NotSoRandom(11111, 22222));
        }
    }
}
