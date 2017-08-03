using CodeWarsSolutions.SevenKyu;
using NUnit.Framework;

namespace CodeWarsSolutions.Test.SevenKyu
{
    
    [TestFixture]
    public class GrowingPlantsTests
    {

        [Test]
        public void BasicTests()
        {
            var kata = new GrowingPlants();

            Assert.AreEqual(10, kata.GrowingPlant(100, 10, 910));

            Assert.AreEqual(1, kata.GrowingPlant(10, 9, 4));


        }

    }
}
