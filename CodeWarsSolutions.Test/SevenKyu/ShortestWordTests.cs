using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;

namespace CodeWarsSolutions.Test.SevenKyu
{
    [TestFixture]
    public class ShortestWordTests
    { 
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(3, ShortestWord.FindShortForTest("bitcoin take over the world maybe who knows perhaps"));
            Assert.AreEqual(3, ShortestWord.FindShortForTest("turns out random test cases are easier than writing out basic ones"));
        }
    }
}
