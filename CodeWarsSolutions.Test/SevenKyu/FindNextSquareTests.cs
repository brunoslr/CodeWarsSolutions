using CodeWarsSolutions.SevenKyu;
using NUnit.Framework;

namespace CodeWarsSolutions.Test.SevenKyu
{
    [TestFixture]
    public class FindNextSquareTests
    {
        [Test]
        [TestCase(155, ExpectedResult = -1)]
        [TestCase(121, ExpectedResult = 144)]
        [TestCase(625, ExpectedResult = 676)]
        [TestCase(319225, ExpectedResult = 320356)]
        [TestCase(15241383936, ExpectedResult = 15241630849)]
        public static long FixedTest(long num)
        {
            return FindNextSquareClass.FindNextSquare(num);
        }
    }
}
