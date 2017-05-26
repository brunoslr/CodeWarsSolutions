using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;

namespace CodeWarsSolutions.Test.SevenKyu
{
   
    [TestFixture]
    public class KnapsackLightTests
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(10, KnapsackLightClass.KnapsackLight(10, 5, 6, 4, 8));

            Assert.AreEqual(16, KnapsackLightClass.KnapsackLight(10, 5, 6, 4, 9));

            Assert.AreEqual(0, KnapsackLightClass.KnapsackLight(10, 2, 11, 3, 1));

            Assert.AreEqual(15, KnapsackLightClass.KnapsackLight(15, 2, 20, 3, 2));

            Assert.AreEqual(3, KnapsackLightClass.KnapsackLight(2, 5, 3, 4, 5));

            Assert.AreEqual(4, KnapsackLightClass.KnapsackLight(4, 3, 3, 4, 4));

            Assert.AreEqual(3, KnapsackLightClass.KnapsackLight(3, 5, 3, 8, 10));
        }
    }
}
