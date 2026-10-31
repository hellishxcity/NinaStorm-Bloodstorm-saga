using UnityEngine;

namespace NinaStorm
{
    [RequireComponent(typeof(NinaHealth))]
    public class NinaEnemyAI : MonoBehaviour
    {
        public Transform target;
        public float detectionRange = 12f;
        public float attackRange = 1.7f;
        public float moveSpeed = 2.6f;
        public float attackDamage = 12f;
        public float attackCooldown = 1.6f;
        public bool isBoss;
        private NinaHealth health;
        private float nextAttackTime;

        private void Awake() { health = GetComponent<NinaHealth>(); }

        private void Update()
        {
            if (health == null || health.IsDead || target == null) return;
            Vector3 delta = target.position - transform.position;
            delta.y = 0f;
            float distance = delta.magnitude;
            if (distance > detectionRange) return;

            if (delta.sqrMagnitude > 0.001f)
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(delta), 7f * Time.deltaTime);

            if (distance > attackRange)
                transform.position += delta.normalized * moveSpeed * Time.deltaTime;
            else if (Time.time >= nextAttackTime)
            {
                nextAttackTime = Time.time + attackCooldown;
                NinaHealth playerHealth = target.GetComponentInParent<NinaHealth>();
                if (playerHealth != null) playerHealth.TakeDamage(attackDamage * (isBoss ? 1.8f : 1f));
            }
        }

        public void OnDeath()
        {
            // Later milestones: spawn loot, award XP/Blood Essence, and trigger quest progress.
            gameObject.SetActive(false);
        }
    }
}