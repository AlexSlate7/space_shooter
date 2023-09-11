using System.Collections.Generic;
using Code.Infractructure.Services;
using Code.Infractructure.Services.PersistentProgress;
using UnityEngine;

namespace Code.Infrastructure.AssetManagement
{
    public interface IGameFactory : IService
    {
        GameObject CreatePlayer(GameObject at);
        void CreateHud();
        List<ISavedProgressReader> ProgressReaders { get; }
        List<ISavedProgress> ProgressWriters { get; }
        void Cleanup();
    }
}