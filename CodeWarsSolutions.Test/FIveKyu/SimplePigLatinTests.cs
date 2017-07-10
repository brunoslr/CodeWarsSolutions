using NUnit.Framework;
using CodeWarsSolutions.FiveKyu;

namespace CodeWarsSolutions.Test.FIveKyu
{
    using System;

    [TestFixture]
    class SimplePigLatinTests
    {
       

        [Test]
        public void PigItTests()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", SimplePigLatin.PigIt("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", SimplePigLatin.PigIt("This is my string"));
        }
    }

}
