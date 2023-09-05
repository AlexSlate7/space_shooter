using System;

namespace Code.Data
{
    [Serializable]
    public class PlayerProgress
    {
        public WorldData WorldData;
        public string InitialLevel;

        public PlayerProgress(string initialLevel)
        {
            InitialLevel = initialLevel;
        }
    }
}

