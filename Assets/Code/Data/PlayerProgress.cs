﻿using System;

namespace Code.Data
{
    [Serializable]
    public class PlayerProgress
    {
        public State PlayerState;
        public WorldData WorldData;

        public PlayerProgress(string initialLevel)
        {
            WorldData = new WorldData(initialLevel);
            PlayerState = new State();
        }
    }
}

