using Code.Data;
using Code.Infractructure.Services.PersistentProgress;
using UnityEngine;

namespace Code.Player
{
    public class PlayerHealth : MonoBehaviour, ISavedProgress
    {
        private State _state;
        public float Current
        {
            get => _state.CurrentHP; 
            set => _state.CurrentHP = value; 
        }

        public float Max
        {
            get => _state.MaxHP; 
            set => _state.MaxHP = value; 
        }
        
        public void LoadProgress(PlayerProgress progress)
        {
            _state = progress.PlayerState;
        }

        public void UpdateProgress(PlayerProgress progress)
        {
            progress.PlayerState.CurrentHP = Current;
            progress.PlayerState.MaxHP = Max;
        }

        public void TakeDamage(float damage)
        {
            if (Current <= 0)
                return;
            
            Current -= damage;
        }
    }
}