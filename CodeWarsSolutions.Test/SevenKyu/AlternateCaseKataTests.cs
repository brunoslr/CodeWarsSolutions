using CodeWarsSolutions.SevenKyu;
using NUnit.Framework;


namespace CodeWarsSolutions.Test.SevenKyu
{
    [TestFixture]
    class AlternateCaseKataTests
    {
        [Test]
        public void AlternateCaseTests()
        {
            Assert.AreEqual("ABC", AlternateCaseKata.alternateCase("abc"));
            Assert.AreEqual("abc", AlternateCaseKata.alternateCase("ABC"));
            Assert.AreEqual("hELLO wORLD", AlternateCaseKata.alternateCase("Hello World"));
        }
    }
}
