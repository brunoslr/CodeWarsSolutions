using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;

namespace CodeWarsSolutions.Test.SevenKyu
{
    using System;
    [TestFixture]
    public class CypherEasyTest
    {
        [Test]
        public void BasicTest()
        {
            Assert.AreEqual("Gug hgs g cgt", CypherEasy.Encode("Ala has a cat"));
            Assert.AreEqual("GBCE", CypherEasy.Encode("ABCD"));
            Assert.AreEqual("Gug hgs g cgt", CypherEasy.Encode("Ala has a cat"));
            Assert.AreEqual("agedyropulik", CypherEasy.Encode("gaderypoluki"));
            Assert.AreEqual("Ala has a cat", CypherEasy.Decode("Gug hgs g cgt"));
            Assert.AreEqual("gaderypoluki", CypherEasy.Decode("agedyropulik"));
            Assert.AreEqual("ABCD", CypherEasy.Decode("GBCE"));
        }
    }
}
