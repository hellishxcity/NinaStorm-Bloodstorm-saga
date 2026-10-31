using UnityEngine;

namespace NinaStorm
{
    public class NinaCombatController : MonoBehaviour
    {
        public float attackRange = 2.1f;
        public float attackRadius = 1.15f;
        public float attackDamage = 25f;
        public float attackCooldown = 0.42f;
        public LayerMask targetLayers = ~0;
        public NinaHealth ownHealth;
        public float healOnKill = 8f;

        private float nextAttackTime;
        private int comboStep;

        private void Awake()
        {
            if (ownHealth == null) ownHealth = GetComponent<NinaHealth>();
        }

        private void Update()
        {
            if (!Application.isMobilePlatform &&
                (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.J)))
                Attack();
        }

        public void Attack()
        {
            if (Time.time < nextAttackTime) return;
            nextAttackTime = Time.time + attackCooldown;
            comboStep = comboStep % 3 + 1;

            Vector3 center = transform.position + Vector3.up * 1.1f + transform.forward * (attackRange * 0.55f);
            Collider[] hits = Physics.OverlapSphere(center, attackRadius, targetLayers, QueryTriggerInteraction.Ignore);
            bool killedEnemy = false;
            foreach (Collider hit in hits)
            {
                if (hit.transform == transform || hit.transform.IsChildOf(transform)) continue;
                NinaHealth health = hit.GetComponentInParent<NinaHealth>();
                if (health == null || health.IsDead) continue;
                float damage = attackDamage * (comboStep == 3 ? 1.6f : 1f);
                bool wasAlive = !health.IsDead;
                health.TakeDamage(damage);
                if (wasAlive && health.IsDead) killedEnemy = true;
            }

            if (killedEnemy && ownHealth != null) ownHealth.Heal(healOnKill);
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position + Vector3.up * 1.1f + transform.forward * (attackRange * 0.55f), attackRadius);
        }
    }
}