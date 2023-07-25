using UnityEngine;
using Code.Infrastructure;
using Code.Services.Input;
using Code.CameraLogic;

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
            CameraFollow();
        }


        private void Update()
        {
            Vector3 movementVector = Vector3.zero;

            if (_inputService.Axis.sqrMagnitude > 0.001)
            {
                movementVector = _camera.transform.TransformDirection(_inputService.Axis);
                movementVector.Normalize();
            }
            CharacterController.Move(MovementSpeed * movementVector * Time.deltaTime);
        }

        private void CameraFollow() => _camera.GetComponent<CameraFollow>().Follow(gameObject);
    }
}

