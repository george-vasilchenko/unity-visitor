﻿using UnityEngine;

namespace Assets.Src.Runtime.Version1.Characters
{
    public abstract class CharacterBase : MonoBehaviour
    {
        public abstract CharacterStats Stats { get; }

        public abstract void Attack(IDamageable other);

        protected abstract int CalculateDamage();
    }
}