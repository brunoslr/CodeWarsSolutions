using CodeWarsSolutions.SixKyu;
using NUnit.Framework;

namespace CodeWarsSolutions.Test.SixKyu
{
    [TestFixture]
    public class PrimesWithoutLoopTests
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(new PrimesWithoutLoop().IsPrime(3), true);
            Assert.AreEqual(new PrimesWithoutLoop().IsPrime(32), false);
        }
    }
}
