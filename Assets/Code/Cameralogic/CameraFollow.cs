using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Code.CameraLogic
{

    public class CameraFollow : MonoBehaviour
    {
        [SerializeField]
        private Transform _following;

        private void LateUpdate()
        {
            if (_following == null)
                return;

            transform.position = new Vector3(_following.position.x, 0, -10);

        }

        public void Follow(GameObject following) => _following = following.transform;
    }


}
