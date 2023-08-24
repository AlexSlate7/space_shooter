using UnityEngine;
using Code.Services.Input;
using Code.Infractructure.Services;

namespace Code.Player
{

    public class PlayerMove : MonoBehaviour
    {
        public float MovementSpeed;

        private IInputService _inputService;
        private Camera _camera;

        private void Awake()
        {
            _inputService = AllServices.Container.Single<IInputService>();
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
            transform.position += movementVector * (MovementSpeed * Time.deltaTime);
        }

    }
}

