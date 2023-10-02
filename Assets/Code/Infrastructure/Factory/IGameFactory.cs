using System;
using System.Collections.Generic;
using Code.Infractructure.Services;
using Code.Infractructure.Services.PersistentProgress;
using UnityEngine;

namespace Code.Infrastructure.AssetManagement
{
    public interface IGameFactory : IService
    {
        GameObject CreatePlayer(GameObject at);
        GameObject PlayerGameObject { get; }
        event Action PlayerCreated;
        List<ISavedProgressReader> ProgressReaders { get; }
        List<ISavedProgress> ProgressWriters { get; }
        void CreateHud();
        void Cleanup();
    }
}