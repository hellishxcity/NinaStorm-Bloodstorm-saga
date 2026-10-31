using UnityEngine;

namespace NinaStorm
{
    public class NinaBloodMagic : MonoBehaviour
    {
        [Min(0)] public int bloodEssence = 3;
        public int maxBloodEssence = 5;
        public float projectileRange = 18f;
        public float bloodSpikeDamage = 40f;
        public float badBloodDamage = 100f;
        public float bloodTimesDuration = 10f;
        public LayerMask targetLayers = ~0;

        public void BloodSpike()
        {
            if (!SpendEssence(1)) return;
            Vector3 origin = transform.position + Vector3.up * 1.2f;
            Vector3 direction = transform.forward;
            if (Physics.Raycast(origin, direction, out RaycastHit hit, projectileRange, targetLayers, QueryTriggerInteraction.Ignore))
            {
                NinaHealth health = hit.collider.GetComponentInParent<NinaHealth>();
                if (health != null && health.transform != transform) health.TakeDamage(bloodSpikeDamage);
            }
        }

        public void BadBlood()
        {
            if (!SpendEssence(2)) return;
            Vector3 origin = transform.position + Vector3.up * 1.2f;
            if (Physics.Raycast(origin, transform.forward, out RaycastHit hit, projectileRange, targetLayers, QueryTriggerInteraction.Ignore))
            {
                NinaHealth health = hit.collider.GetComponentInParent<NinaHealth>();
                if (health != null && health.transform != transform)
                    health.TakeDamage(health.maxHealth <= badBloodDamage ? badBloodDamage : badBloodDamage);
            }
        }

        public void BloodTimes()
        {
            if (!SpendEssence(2)) return;
            Collider[] targets = Physics.OverlapSphere(transform.position, projectileRange, targetLayers);
            foreach (Collider item in targets)
            {
                NinaEnemyAI enemy = item.GetComponentInParent<NinaEnemyAI>();
                if (enemy != null && !enemy.isBoss && !enemy.GetComponent<NinaHealth>().IsDead)
                    enemy.StartCoroutine(ConfuseRoutine(enemy));
            }
        }

        private System.Collections.IEnumerator ConfuseRoutine(NinaEnemyAI enemy)
        {
            Transform originalTarget = enemy.target;
            enemy.target = FindNearestOtherEnemy(enemy);
            yield return new WaitForSeconds(bloodTimesDuration);
            if (enemy != null) enemy.target = originalTarget;
        }

        private Transform FindNearestOtherEnemy(NinaEnemyAI source)
        {
            NinaEnemyAI[] enemies = FindObjectsOfType<NinaEnemyAI>();
            NinaEnemyAI nearest = null;
            float best = float.MaxValue;
            foreach (NinaEnemyAI enemy in enemies)
            {
                if (enemy == source || enemy.isBoss || enemy.GetComponent<NinaHealth>().IsDead) continue;
                float distance = Vector3.Distance(source.transform.position, enemy.transform.position);
                if (distance < best) { best = distance; nearest = enemy; }
            }
            return nearest != null ? nearest.transform : transform;
        }

        public void AddEssence(int amount) { bloodEssence = Mathf.Clamp(bloodEssence + amount, 0, maxBloodEssence); }

        private bool SpendEssence(int amount)
        {
            if (bloodEssence < amount) return false;
            bloodEssence -= amount;
            return true;
        }
    }
}