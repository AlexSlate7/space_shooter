using Code.Infrastructure.AssetManagement;
using UnityEngine;

namespace Code.Infrastructure.AssetManagement
{
    public class GameFactory : IGameFactory
    {

        private readonly IAssets _assets;

        public GameFactory(IAssets assets)
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