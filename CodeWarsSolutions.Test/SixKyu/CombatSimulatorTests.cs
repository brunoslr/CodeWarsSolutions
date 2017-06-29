using CodeWarsSolutions.SixKyu;
using NUnit.Framework;

namespace CodeWarsSolutions.Test.SixKyu
{
    [TestFixture]
    public class CombatSimulatorTests
    {
        [Test]
        public void PcDeadTest()
        {
            var simulator = new CombatSimulator(10, 10, 15, 12);
            int[] pcModifiers = { -1, 2, -2 };
            var pcHitResult = simulator.PcAttack(2, pcModifiers, 5);
            Assert.AreEqual(CombatSimulator.HitResult.FightOn, pcHitResult);
            int[] enemyHitModifiers = { 5 };
            var enemyHitResult = simulator.EnemyAttack(6, enemyHitModifiers, 12);
            Assert.AreEqual(CombatSimulator.HitResult.PcDead, enemyHitResult);
        }

        [Test]
        public void FightOnTest()
        {
            var simulator = new CombatSimulator(10, 10, 15, 12);
            int[] pcModifiers = { -1, 2, -2 };
            var pcHitResult = simulator.PcAttack(13, pcModifiers, 5);
            Assert.AreEqual(CombatSimulator.HitResult.FightOn, pcHitResult);
            int[] enemyHitModifiers = { 5 };
            var enemyHitResult = simulator.EnemyAttack(4, enemyHitModifiers, 12);
            Assert.AreEqual(CombatSimulator.HitResult.FightOn, enemyHitResult);
        }
    }
}

