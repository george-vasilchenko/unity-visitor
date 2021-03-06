﻿using System;
using Assets.Src.Runtime.Common;
using UnityEngine;

namespace Assets.Src.Runtime.Before.Characters
{
    public class Archer : CharacterBase
    {
        public override int Level { get; protected set; } = 1;

        public override CharacterStats Stats { get; protected set; } = new CharacterStats
        {
            Agility = 6,
            Intelligence = 2,
            Strength = 2
        };

        public override void Attack(IDamageable other)
        {
            // Shoot an arrow
            other.ReceiveDamage(this.CalculateDamage());
        }

        protected override int CalculateDamage()
        {
            var agilityPart = this.Stats.Agility * 0.5f;
            var intelligencePart = this.Stats.Intelligence * 0.25f;
            var strengthPart = this.Stats.Strength * 0.25f;

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
                        Agility = 6,
                        Intelligence = 2,
                        Strength = 2
                    };

                    break;

                case 3:
                    deltas = new CharacterStats
                    {
                        Agility = 6,
                        Intelligence = 4,
                        Strength = 5
                    };

                    break;

                default: throw new ArgumentOutOfRangeException("");
            }
            this.Stats = CharacterStats.CreateFromOtherWithDeltas(this.Stats, deltas);
        }
    }
}