using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;

namespace CodeWarsSolutions.Test.SevenKyu
{

    [TestFixture]
    public class TriangularTreasureTest
    {
        // You can test here

        [Test]
        public static void TriangularTwoShouldBeThree()
        {
            Assert.AreEqual(3, TriangularTreasure.Triangular(2));
        }

        [Test]
        public static void TriangularFourShouldBeTen()
        {
            Assert.AreEqual(10, TriangularTreasure.Triangular(4));
        }
    }
}
