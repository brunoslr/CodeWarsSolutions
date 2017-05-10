using NUnit.Framework;
using CodeWarsSolutions.SevenKyu;

namespace CodeWarsSolutions.Test.SevenKyu
{
    [TestFixture]
    public class SimpleFunPlantDoublingTests
    {
        [Test]
        public void BasicTests()
        {
            var kata = new SimpleFunPlantDoubling();

            Assert.AreEqual(2, kata.PlantDoubling(5));

            Assert.AreEqual(1, kata.PlantDoubling(8));

            Assert.AreEqual(29, kata.PlantDoubling(536870911));

            Assert.AreEqual(1, kata.PlantDoubling(1));

        }
    }
}
