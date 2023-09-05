using System;
using UnityEngine.Serialization;

namespace Code.Data
{
    [Serializable]
    public class WorldData
    {
        public Vector3Data Position;
        public string Level;

        public WorldData(string initialLevel)
        {
            Level = initialLevel;
        }
    }
}