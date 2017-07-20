using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;

namespace CodeWarsSolutions.Test.SevenKyu
{
    namespace Solution
    {
       
        [TestFixture]
        public class LuckyNumberTests
        {
            [Test]
            public void LuckyNumbersFixedTests()
            {
                Assert.AreEqual(new int[] { 7, 70, 17 }, LuckyNumber.FilterLucky(new int[] { 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }));
                Assert.AreEqual(new int[] { }, LuckyNumber.FilterLucky(new int[] { }));
            }
        }
    }
}
