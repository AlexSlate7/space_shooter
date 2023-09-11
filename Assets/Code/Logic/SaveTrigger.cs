using Code.Infractructure.Services;
using Code.Infrastructure.Services.SaveLoad;
using UnityEngine;

namespace Code.Logic
{
    /// <summary>
    /// Call when pause appears.
    /// </summary>
    public class SaveTrigger : MonoBehaviour
    {
        private ISaveLoadService _saveLoadService;
        
        private void Awake()
        {
            _saveLoadService = AllServices.Container.Single<ISaveLoadService>();
        }

        public void SaveProgress()
        {
            _saveLoadService.SaveProgress();
            Debug.Log("Progress Saved.");
        }
    }
}