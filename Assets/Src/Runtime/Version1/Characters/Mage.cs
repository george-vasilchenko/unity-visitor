using UnityEngine;

namespace Assets.Src.Runtime.Version1.Characters
{
    public class Mage : CharacterBase
    {
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
            var agilityPart = this.Stats.Agility * 0.3f;
            var intelligencePart = this.Stats.Intelligence * 0.6f;
            var strengthPart = this.Stats.Strength * 0.1f;

            return Mathf.FloorToInt(agilityPart + intelligencePart + strengthPart);
        }
    }
}