using UnityEngine;

namespace NinaStorm
{
    public class NinaHealth : MonoBehaviour
    {
        [Min(1f)] public float maxHealth = 100f;
        public float CurrentHealth { get; private set; }
        public bool IsDead { get; private set; }

        private void Awake()
        {
            CurrentHealth = maxHealth;
        }

        public void TakeDamage(float amount)
        {
            if (IsDead || amount <= 0f) return;
            CurrentHealth = Mathf.Max(0f, CurrentHealth - amount);
            if (CurrentHealth <= 0f)
            {
                IsDead = true;
                SendMessage("OnDeath", SendMessageOptions.DontRequireReceiver);
            }
        }

        public void Heal(float amount)
        {
            if (IsDead || amount <= 0f) return;
            CurrentHealth = Mathf.Min(maxHealth, CurrentHealth + amount);
        }

        public void Revive(float health = -1f)
        {
            IsDead = false;
            CurrentHealth = health < 0f ? maxHealth : Mathf.Clamp(health, 1f, maxHealth);
        }
    }
}