using Code.Infractructure.Services;
using UnityEngine;

namespace Code.Infrastructure.AssetManagement
{
    public interface IGameFactory : IService
    {
        GameObject CreatePlayer(GameObject at);
        void CreateHud();
    }
}