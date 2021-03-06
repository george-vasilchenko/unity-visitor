﻿using Assets.Src.Runtime.After.Visitors;
using Assets.Src.Runtime.Common;
using UnityEngine;

namespace Assets.Src.Runtime.After.Characters
{
    public class Mage : CharacterBase
    {
        private readonly ICharacterVisitor<StatsDistribution> statsDistributionVisitor = new StatsDistributionVisitor();
        private readonly ICharacterVisitor<CharacterStats> statsIncreasePerLevelVisitor = new StatsIncreasePerLevelVisitor();

        public override int Level { get; protected set; } = 1;

        public override CharacterStats Stats { get; protected set; } = new CharacterStats
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

        public override void IncreaseLevel()
        {
            this.Level++;

            var deltas = this.statsIncreasePerLevelVisitor.Visit(this);

            this.Stats = CharacterStats.CreateFromOtherWithDeltas(this.Stats, deltas);
        }
    }
}