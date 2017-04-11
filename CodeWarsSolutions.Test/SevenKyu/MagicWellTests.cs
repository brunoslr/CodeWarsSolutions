using CodeWarsSolutions.SevenKyu;
using NUnit.Framework;
using System;


namespace CodeWarsSolutions.Test.SevenKyu
{
    [TestFixture]
    class MagicWellTests { 

        [Test]
        public void BasicTests()
        {
            var kata = new MagicWell();

            Assert.AreEqual(8, kata.MagicalWell(1, 2, 2), "");
            Assert.AreEqual(1, kata.MagicalWell(1, 1, 1), "");
            Assert.AreEqual(128, kata.MagicalWell(6, 5, 3), "");
        }
    }
}
