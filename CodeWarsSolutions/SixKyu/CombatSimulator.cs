using System;
using System.Linq;

namespace CodeWarsSolutions.SixKyu
{
    public class CombatSimulator
    {
        private int _pcHitPoints, _enemyHitPoints;
        private readonly int _pcDefense, _enemyDefense;

        public enum HitResult
        {
            FightOn,
            PcDead,
            EnemyDead
        }

        public CombatSimulator(int pcHitPoints, int pcDefense, int enemyHitPoints, int enemyDefense)
        {
            _pcHitPoints = pcHitPoints;
            _pcDefense = pcDefense;
            _enemyHitPoints = enemyHitPoints;
            _enemyDefense = enemyDefense;

        }

        private int AttackPower(int attackRoll, int[] modifiers )
        {
            return attackRoll + modifiers?.Sum() ?? 0;
        }

        public HitResult PcAttack(int attackRoll, int[] modifiers, int damage)
        {
            if (_pcHitPoints <= 0) return HitResult.PcDead;

            if (AttackPower(attackRoll,modifiers) > _enemyDefense) _enemyHitPoints -= damage;

            return (_enemyHitPoints <= 0) ? HitResult.EnemyDead : HitResult.FightOn;
        }

        public HitResult EnemyAttack(int attackRoll, int[] modifiers, int damage)
        {
            if (_enemyHitPoints <= 0) return HitResult.PcDead;

            if (AttackPower(attackRoll, modifiers) > _pcDefense) _pcHitPoints -= damage;

            return (_pcHitPoints <= 0) ? HitResult.PcDead : HitResult.FightOn;
        }
    }
}
