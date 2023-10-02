using System;
using UnityEngine;

namespace Code.Enemy
{
    public class SimpleMove : MonoBehaviour
    {
        [SerializeField] private Vector2 direction = Vector2.down;
        [SerializeField] private float speed = 3f;

        private void Update()
        {
            transform.position = (Vector2)transform.position + direction * (speed * Time.deltaTime);
        }
    }
}