using Code.CameraLogic;
using Code.Logic;
using UnityEngine;

namespace Code.Infrastructure
{
    public class LoadLevelState : IPayloadedState<string>
    {
        private const string SpawnPointTag = "SpawnPoint";
        private readonly GameStateMachine _stateMachine;
        private readonly SceneLoader _sceneLoader;
        private readonly LoadCurtain _curtain;
        private readonly IGameFactory _gameFactory;

        public LoadLevelState(GameStateMachine stateMachine, SceneLoader sceneLoader, LoadCurtain curtain)
        {
            _stateMachine = stateMachine;
            _sceneLoader = sceneLoader;
            _curtain = curtain;
        }

        public void Enter(string sceneName)
        {
            _curtain.Show();
            _sceneLoader.Load(sceneName, OnLoaded);
        }

        public void Exit()
        {
            _curtain.Hide();
        }

        private void OnLoaded()
        {
            GameObject player = _gameFactory.CreatePlayer(GameObject.FindWithTag(SpawnPointTag));
            _gameFactory.CreateHud();

            CameraFollow(player);

            _stateMachine.Enter<GameLoopState>();
        }



        private static void CameraFollow (GameObject player)
        {
            Camera.main
                .GetComponent<CameraFollow>()
                .Follow(player);
        }
    }
}

