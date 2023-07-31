using Code.Infrastructure.AssetManagement;
using UnityEngine;

namespace Code.Infrastructure
{
    public class GameFactory : IGameFactory
    {

        private readonly IAssetProvider _assets;

        public GameFactory(IAssetProvider assets)
        {
            _assets = assets;
        }

        public void CreateHud()
        {
            _assets.Instantiate(AssetPath.HudPath);
        }

        public GameObject CreatePlayer(GameObject at)
        {
            return _assets.Instantiate(AssetPath.PlayerPath, at: at.transform.position);
        }
    }
}