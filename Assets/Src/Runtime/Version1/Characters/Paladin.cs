using UnityEngine;

namespace Assets.Src.Runtime.Version1.Characters
{
    public class Paladin : CharacterBase
    {
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
            var agilityPart = this.Stats.Agility * 0.2f;
            var intelligencePart = this.Stats.Intelligence * 0.2f;
            var strengthPart = this.Stats.Strength * 0.6f;

            return Mathf.FloorToInt(agilityPart + intelligencePart + strengthPart);
        }
    }
}