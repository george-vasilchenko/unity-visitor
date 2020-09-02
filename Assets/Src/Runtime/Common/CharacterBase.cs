using UnityEngine;

namespace Assets.Src.Runtime.Common
{
    public abstract class CharacterBase : MonoBehaviour
    {
        public abstract int Level { get; protected set; }

        public abstract CharacterStats Stats { get; protected set; }

        public abstract void Attack(IDamageable other);

        protected abstract int CalculateDamage();

        public abstract void IncreaseLevel();
    }
}