using System;
using Code.Player;
using UnityEngine;

namespace Code.UI
{
    public class ActorUI : MonoBehaviour
    {
        public HpBar HpBar;

        private PlayerHealth _playerHealth;

        private void OnDestroy()
        {
            _playerHealth.HealthChanged -= UpdateHpBar;
        }

        public void Construct(PlayerHealth heath)
        {
            _playerHealth = heath;

            _playerHealth.HealthChanged += UpdateHpBar;
        }

        private void UpdateHpBar()
        {
            HpBar.SetValue(_playerHealth.Current, _playerHealth.Max);
        }
    }
}