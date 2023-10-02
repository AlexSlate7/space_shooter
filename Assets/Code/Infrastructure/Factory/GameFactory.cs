﻿using System;
using System.Collections.Generic;
using System.Threading;
using Code.Infractructure.Services.PersistentProgress;
using Code.Infrastructure.AssetManagement;
using UnityEngine;

namespace Code.Infrastructure.Factory
{
    public class GameFactory : IGameFactory
    {
        private readonly IAssets _assets;

        public event Action PlayerCreated;
        
        public GameObject PlayerGameObject { get; set; }
        public List<ISavedProgressReader> ProgressReaders { get; } = new List<ISavedProgressReader>();
        public List<ISavedProgress> ProgressWriters { get; } = new List<ISavedProgress>();


        public GameFactory(IAssets assets)
        {
            _assets = assets;
        }

        public GameObject CreateHud()
        {
            return InstantiateRegistered(AssetPath.HudPath);
        }

        public GameObject CreatePlayer(GameObject at)
        {
            PlayerGameObject = InstantiateRegistered(AssetPath.PlayerPath, at.transform.position);
            PlayerCreated?.Invoke();
            return PlayerGameObject;
        }

        public void Cleanup()
        {
            ProgressReaders.Clear();
            ProgressWriters.Clear();
        }

        private GameObject InstantiateRegistered(string prefabPath, Vector3 at)
        {
            GameObject gameObject = _assets.Instantiate(prefabPath, at);
            RegisterProgressWatchers(gameObject);
            return gameObject;
        }private GameObject InstantiateRegistered(string prefabPath)
        {
            GameObject gameObject = _assets.Instantiate(prefabPath);
            RegisterProgressWatchers(gameObject);
            return gameObject;
        }

        private void RegisterProgressWatchers(GameObject gameObject)
        {
            foreach (ISavedProgressReader progressReader in gameObject.GetComponentsInChildren<ISavedProgressReader>())
            {
                Register(progressReader);
            }
        }

        private void Register(ISavedProgressReader progressReader)
        {
            if (progressReader is ISavedProgress progressWriter)
                ProgressWriters.Add(progressWriter);
            
            ProgressReaders.Add(progressReader);
        }
    }
}