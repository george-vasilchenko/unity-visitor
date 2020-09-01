using Assets.Src.Runtime.Version2.Visitors;
using UnityEngine;

namespace Assets.Src.Runtime.Version2.Characters
{
    public class Mage : CharacterBase
    {
        private readonly ICharacterVisitor<StatsDistribution> statsDistributionVisitor = new StatsDistributionVisitor();

        public override CharacterStats Stats { get; } = new CharacterStats
        {
            Agility = 3,
            Intelligence = 6,
            Strength = 1
        };

        public override void Attack(IDamageable other)
        {
            // Launch a fire ball
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