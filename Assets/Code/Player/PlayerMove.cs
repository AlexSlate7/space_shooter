using UnityEngine;
using Code.Infrastructure;
using Code.Services.Input;

namespace Code.Player
{

    public class PlayerMove : MonoBehaviour
    {
        public CharacterController CharacterController;
        public float MovementSpeed;

        private IInputService _inputService;
        private Camera _camera;

        private void Awake()
        {
            _inputService = Game.InputService;
        }

        private void Start()
        {
            _camera = Camera.main;
        }


        private void Update()
        {
            Vector3 movementVector = Vector3.zero;

            if (_inputService.Axis.sqrMagnitude > 0.001f)
            {
                movementVector = _camera.transform.TransformDirection(_inputService.Axis);
                movementVector.Normalize();
            }
            CharacterController.Move(MovementSpeed * movementVector * Time.deltaTime);
        }

    }
}

