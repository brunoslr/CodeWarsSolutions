using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;

namespace CodeWarsSolutions.Test.SevenKyu
{

    [TestFixture]
    class SimpleFunRegexHappyCharTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFunRegexHappyChar();

            Assert.AreEqual(true, kata.HappyG("gg0gg3gg0gg"));

            Assert.AreEqual(false, kata.HappyG("gog"));

            Assert.AreEqual(false, kata.HappyG("ggg ggg g ggg"));

            Assert.AreEqual(true, kata.HappyG("A half of a half is a quarter."));

            Assert.AreEqual(false, kata.HappyG("good grief"));

            Assert.AreEqual(true, kata.HappyG("bigger is ggooder"));

            Assert.AreEqual(true, kata.HappyG("gggggggggg"));

        }
    }
}