using System;
using Assets.Src.Runtime.Common;
using UnityEngine;

namespace Assets.Src.Runtime.Before.Characters
{
    public class Paladin : CharacterBase
    {
        public override int Level { get; protected set; } = 1;

        public override CharacterStats Stats { get; protected set; } = new CharacterStats
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
            var agilityPart = this.Stats.Agility * 0.2f;
            var intelligencePart = this.Stats.Intelligence * 0.2f;
            var strengthPart = this.Stats.Strength * 0.6f;

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
                        Agility = 2,
                        Intelligence = 2,
                        Strength = 6
                    };

                    break;

                case 3:
                    deltas = new CharacterStats
                    {
                        Agility = 3,
                        Intelligence = 2,
                        Strength = 10
                    };

                    break;

                default: throw new ArgumentOutOfRangeException("");
            }

            this.Stats = CharacterStats.CreateFromOtherWithDeltas(this.Stats, deltas);
        }
    }
}