using UnityEngine;

namespace Assets.Src.Runtime.Version1.Characters
{
    public class Archer : CharacterBase
    {
        public override CharacterStats Stats { get; } = new CharacterStats
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
    }
}