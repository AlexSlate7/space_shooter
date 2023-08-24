using System;
using UnityEngine;

namespace Code.Enemy
{
    public class Clash : MonoBehaviour
    {
        public TriggerObserver TriggerObserver;

        private void Start()
        {
            TriggerObserver.TriggerEnter += TriggerEnter;
        }

        private void TriggerEnter(Collider2D obj)
        {
            // clash logic (add later)
        }

    }
}