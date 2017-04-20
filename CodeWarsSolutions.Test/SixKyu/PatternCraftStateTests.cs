using NUnit.Framework;
using CodeWarsSolutions.SixKyu;

namespace CodeWarsSolutions.Test.SixKyu
{
    [TestFixture]
    class PatternCraftStateTests
    {
  
        [Test]
        public void _0_TankState()
        {
            IUnit2 tank = new Tank();

            Assert.AreEqual(true, tank.CanMove);
            Assert.AreEqual(5, tank.Damage);
        }

        [Test]
        public void _1_SiegeState()
        {
            IUnit2 tank = new Tank();
            tank.State = new SiegeState();

            Assert.AreEqual(false, tank.CanMove);
            Assert.AreEqual(20, tank.Damage);
        }

        [Test]
        public void _2_MixState()
        {
            IUnit2 tank = new Tank();

            Assert.AreEqual(true, tank.CanMove);
            tank.State = new SiegeState();
            Assert.AreEqual(20, tank.Damage);
        }
    }
}
