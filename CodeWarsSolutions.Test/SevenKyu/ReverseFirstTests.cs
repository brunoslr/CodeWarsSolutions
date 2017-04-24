using CodeWarsSolutions.SevenKyu;
using NUnit.Framework;

namespace CodeWarsSolutions.Test.SevenKyu
{
    [TestFixture]
    class ReverseFirstTests
    {
        ReverseFirst sut;
        [OneTimeSetUp]
        public void Setup()
        {
            sut = new ReverseFirst();
        }

        [TestCase(new int[] { 5, 2, 3, 4, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { }, new int[] {})]
        [TestCase(new int[] { 111 }, new int[] { 111 })]
        [TestCase(new int[] { 324, 54, 12, 3, 4, 56, 23, 12, 5, 23 }, new int[] { 23, 54, 12, 3, 4, 56, 23, 12, 5, 324 })]
        public void ReverseFirstKataBasicTests(int[] expected, int[] input)
        {
            Assert.AreEqual(expected, sut.FirstReverseTry(input));
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            sut = null;
        }
    }
}
