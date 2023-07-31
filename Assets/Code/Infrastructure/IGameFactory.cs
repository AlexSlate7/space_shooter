using UnityEngine;

namespace Code.Infrastructure
{
    public interface IGameFactory
    {
        GameObject CreatePlayer(GameObject at);
        void CreateHud();
    }
}