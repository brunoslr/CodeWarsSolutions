using System;
using System.Linq;

namespace CodeWarsSolutions.SixKyu
{
    public class CombatSimulator
    {
        private int pcHitPoints, pcDefense, enemyHitPoints, enemyDefense;

        public enum HitResult
        {
            FightOn,
            PcDead,
            EnemyDead
        }

        public CombatSimulator(int pcHitPoints, int pcDefense, int enemyHitPoints, int enemyDefense)
        {
            this.pcHitPoints = pcHitPoints;
            this.pcDefense = pcDefense;
            this.enemyHitPoints = enemyHitPoints;
            this.enemyDefense = enemyDefense;

        }

        public HitResult PcAttack(int attackRoll, int[] modifiers, int damage)
        {
            if (pcHitPoints <= 0) return HitResult.PcDead;

            var attack = attackRoll;

            if (modifiers != null) attack += modifiers.Sum();

            if (attack > enemyDefense) enemyHitPoints -= damage;

            return (enemyHitPoints <= 0) ? HitResult.EnemyDead : HitResult.FightOn;
        }

        public HitResult EnemyAttack(int attackRoll, int[] modifiers, int damage)
        {
            if (enemyHitPoints <= 0) return HitResult.EnemyDead;

            var attack = attackRoll;

            if (modifiers != null) attack += modifiers.Sum();

            if (attack > pcDefense) pcHitPoints -= damage;

            return (pcHitPoints <= 0) ? HitResult.PcDead : HitResult.FightOn;
        }
    }
}
