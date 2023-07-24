using UnityEngine;
using Zenject;

public class PlayerShipInstaller : MonoInstaller
{
    [SerializeField] private GameObject _playerShip;
    [SerializeField] private Transform _spawnPosition;

    public override void InstallBindings()
    {
        var playerInstance =
            Container.InstantiatePrefabForComponent<Player>(
                _playerShip, _spawnPosition.position, Quaternion.identity, null);

        Container.Bind<Player>().FromInstance(playerInstance).
            AsSingle().
            NonLazy();
    }
}