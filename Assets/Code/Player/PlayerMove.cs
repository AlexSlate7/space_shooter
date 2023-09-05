using Code.Data;
using UnityEngine;
using Code.Services.Input;
using Code.Infractructure.Services;
using Code.Infractructure.Services.PersistentProgress;

namespace Code.Player
{

    public class PlayerMove : MonoBehaviour, ISavedProgress
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

        public void LoadProgress(PlayerProgress progress)
        {
            var savedPosition = progress.WorldData.Position;
            transform.position = savedPosition.AsUnityVector();
        }

        public void UpdateProgress(PlayerProgress progress)
        {
            progress.WorldData.Position = transform.position.AsVectorData();
        }
    }
}

