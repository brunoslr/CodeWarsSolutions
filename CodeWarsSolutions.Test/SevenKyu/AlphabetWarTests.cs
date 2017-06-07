using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;

namespace CodeWarsSolutions.Test.SevenKyu
{
    [TestFixture]
    public class AlphabetWarTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("Right side wins!", AlphabetWars.AlphabetWar("z"));
            Assert.AreEqual("Let's fight again!", AlphabetWars.AlphabetWar("zdqmwpbs"));
            Assert.AreEqual("Right side wins!", AlphabetWars.AlphabetWar("zzzzs"));
            Assert.AreEqual("Left side wins!", AlphabetWars.AlphabetWar("wwwwwwz"));
        }
    }
}
