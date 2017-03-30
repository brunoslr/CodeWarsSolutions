
using CodeWarsSolutions.SixKyu;
using NUnit.Framework;

namespace CodeWarsSolutions.Test.SixKyu
{

    [TestFixture]
    public class BuildTowerTests
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(string.Join(",", new[] { "*" }), string.Join(",", BuildTower.TowerBuilder(1)));
            Assert.AreEqual(string.Join(",", new[] { " * ", "***" }), string.Join(",", BuildTower.TowerBuilder(2)));
            Assert.AreEqual(string.Join(",", new[] { "  *  ", " *** ", "*****" }), string.Join(",", BuildTower.TowerBuilder(3)));
        }
    }
    
}
