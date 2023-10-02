using UnityEngine;

namespace Code.Enemy
{
    public class Attack : MonoBehaviour
    {
        public float Cooldown = 1f;
        private float _cooldown;

        private void Update()
        {
            UpdateCooldown();
            
            if (CooldownIsUp())
                StartAttack();
        }

        private void UpdateCooldown()
        {
            if (!CooldownIsUp())
                _cooldown -= Time.deltaTime;
        }

        private bool CooldownIsUp()
        {
            return _cooldown <= 0f;
        }

        private void StartAttack()
        {
            // spawn laser shot
            Debug.Log("Attacking!!");
            _cooldown = Cooldown;
        }
    }
}