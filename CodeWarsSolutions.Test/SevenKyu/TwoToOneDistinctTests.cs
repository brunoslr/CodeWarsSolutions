using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;

namespace CodeWarsSolutions.Test.SevenKyu
{
    [TestFixture]
    public static class TwoToOneDistinctTests
    {
        [Test]
        public static void test1()
        {
            Assert.AreEqual("aehrsty", TwoToOneDistinct.Longest("aretheyhere", "yestheyarehere"));
            Assert.AreEqual("abcdefghilnoprstu", TwoToOneDistinct.Longest("loopingisfunbutdangerous", "lessdangerousthancoding"));
            Assert.AreEqual("acefghilmnoprstuy", TwoToOneDistinct.Longest("inmanylanguages", "theresapairoffunctions"));
        }
    }
}
