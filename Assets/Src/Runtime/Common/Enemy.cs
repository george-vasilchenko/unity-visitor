using UnityEngine;

namespace Assets.Src.Runtime.Common
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