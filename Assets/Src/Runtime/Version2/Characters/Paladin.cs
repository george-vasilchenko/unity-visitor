using Assets.Src.Runtime.Version2.Visitors;
using UnityEngine;

namespace Assets.Src.Runtime.Version2.Characters
{
    public class Paladin : CharacterBase
    {
        private readonly ICharacterVisitor<StatsDistribution> statsDistributionVisitor = new StatsDistributionVisitor();

        public override CharacterStats Stats { get; } = new CharacterStats
        {
            Agility = 3,
            Intelligence = 1,
            Strength = 6
        };

        public override void Attack(IDamageable other)
        {
            // Slash with a sword
            other.ReceiveDamage(this.CalculateDamage());
        }

        protected override int CalculateDamage()
        {
            var distribution = this.statsDistributionVisitor.Visit(this);
            return Mathf.FloorToInt(
                distribution.AgilityPercentage * this.Stats.Agility +
                distribution.IntelligencePercentage * this.Stats.Intelligence +
                distribution.StrengthPercentage * this.Stats.Strength);
        }
    }
}