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
            Assert.AreEqual("Gug hgs g cgt", CipherEasy.Encode("Ala has a cat"));
            Assert.AreEqual("GBCE", CipherEasy.Encode("ABCD"));
            Assert.AreEqual("Gug hgs g cgt", CipherEasy.Encode("Ala has a cat"));
            Assert.AreEqual("agedyropulik", CipherEasy.Encode("gaderypoluki"));
            Assert.AreEqual("Ala has a cat", CipherEasy.Decode("Gug hgs g cgt"));
            Assert.AreEqual("gaderypoluki", CipherEasy.Decode("agedyropulik"));
            Assert.AreEqual("ABCD", CipherEasy.Decode("GBCE"));
        }
    }
}
