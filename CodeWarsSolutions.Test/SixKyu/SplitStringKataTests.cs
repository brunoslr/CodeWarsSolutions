using CodeWarsSolutions.SixKyu;
using NUnit.Framework;

namespace CodeWarsSolutions.Test.SixKyu
{
    [TestFixture]
    public class SplitStringKataTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new string[] { "ab", "c_" }, SplitStringKata.Solution("abc"));
            Assert.AreEqual(new string[] { "ab", "cd", "ef" }, SplitStringKata.Solution("abcdef"));
        }
    }
}
