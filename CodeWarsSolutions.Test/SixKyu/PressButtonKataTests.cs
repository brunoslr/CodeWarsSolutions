using CodeWarsSolutions.SixKyu;
using NUnit.Framework;
using System;

namespace CodeWarsSolutions.Test.SixKyu
{   [TestFixture]
    class PressButtonKataTests
    {
        [Test]
        public void PressButtonBasicTests()
        {
            var kata = new PressButtonKata();

            Assert.AreEqual(1, kata.PressButton(1));

            Assert.AreEqual(7, kata.PressButton(3));

            Assert.AreEqual(14, kata.PressButton(4));

            Assert.AreEqual(175, kata.PressButton(10));

            Assert.AreEqual(1333335000, kata.PressButton(2000));

        }

    }
}
