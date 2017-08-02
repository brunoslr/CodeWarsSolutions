using System;
using CodeWarsSolutions.SevenKyu;
using NUnit.Framework;

namespace CodeWarsSolutions.Test.SevenKyu
{
    [TestFixture]
    class ReverseLetterTests
    {

        [Test]
        public void ReverseLetterBasicTests()
        {
            var kata = new ReverseLetterClass();

            Assert.AreEqual("nahsirk", kata.ReverseLetter("krishan"));

            Assert.AreEqual("nortlu", kata.ReverseLetter("ultr53o?n"));

            Assert.AreEqual("cba", kata.ReverseLetter("ab23c"));

            Assert.AreEqual("nahsirK", kata.ReverseLetter("Krish21an"));

        }
    }
}
