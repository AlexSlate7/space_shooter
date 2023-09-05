using Code.Data;
using UnityEngine;

namespace Code.Infrastructure.Services.SaveLoad
{
    class SaveLoadService : ISaveLoadService
    {
        private const string ProgressKey = "Progress";
        public void SaveProgress()
        {
        }

        public PlayerProgress LoadProgress() =>
            PlayerPrefs.GetString(ProgressKey)?
                .ToDeserialized<PlayerProgress>();
    }
}