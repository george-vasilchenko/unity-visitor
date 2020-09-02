using System;
using Assets.Src.Runtime.Common;
using UnityEngine;

namespace Assets.Src.Runtime.Before.Characters
{
    public class Mage : CharacterBase
    {
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
            var agilityPart = this.Stats.Agility * 0.3f;
            var intelligencePart = this.Stats.Intelligence * 0.6f;
            var strengthPart = this.Stats.Strength * 0.1f;

            return Mathf.FloorToInt(agilityPart + intelligencePart + strengthPart);
        }

        public override void IncreaseLevel()
        {
            this.Level++;

            CharacterStats deltas;

            switch (this.Level)
            {
                case 2:
                    deltas = new CharacterStats
                    {
                        Agility = 3,
                        Intelligence = 5,
                        Strength = 2
                    };

                    break;

                case 3:
                    deltas = new CharacterStats
                    {
                        Agility = 3,
                        Intelligence = 9,
                        Strength = 3
                    };

                    break;

                default: throw new ArgumentOutOfRangeException("");
            }

            this.Stats = CharacterStats.CreateFromOtherWithDeltas(this.Stats, deltas);
        }
    }
}