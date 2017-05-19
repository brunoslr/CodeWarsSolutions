using CodeWarsSolutions.SevenKyu;
using NUnit.Framework;

namespace CodeWarsSolutions.Test.SevenKyu
{
    [TestFixture]
    class ThueMorseTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new ThueMorse();

            Assert.AreEqual(true, kata.IsThueMorse(new int[] { 0, 1, 1, 0 }));

            Assert.AreEqual(true, kata.IsThueMorse(new int[] { 0 }));

            Assert.AreEqual(false, kata.IsThueMorse(new int[] { 1 }));

            Assert.AreEqual(false, kata.IsThueMorse(new int[] { 0, 1, 0, 0 }));
            
        }
    }
}
