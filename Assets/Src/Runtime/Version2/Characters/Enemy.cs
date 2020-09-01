using UnityEngine;

namespace Assets.Src.Runtime.Version2.Characters
{
    public class Enemy : MonoBehaviour, IDamageable
    {
        public int Health = 100;

        public void ReceiveDamage(int amount)
        {
            this.Health -= amount;
        }
    }
}