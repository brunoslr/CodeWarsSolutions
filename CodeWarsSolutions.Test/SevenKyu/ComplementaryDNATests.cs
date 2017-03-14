using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;

namespace CodeWarsSolutions.Test.SevenKyu
{
    [TestFixture]
    public class DnaStrandTest
    {
        [TestCase("AAAA", "TTTT")]
        [TestCase("TAACG", "ATTGC")]
        [TestCase("CATA", "GTAT")]
        public void SimpleTests(string input, string expected)
        {
            Assert.AreEqual(expected, DnaStrand.MakeComplement(input));
        }

    }
}
