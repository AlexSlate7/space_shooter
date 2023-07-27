namespace Code.Infrastructure
{
    public class LoadLevelState : IState
    {
        private readonly GameStateMachine _stateMachine;
        private readonly SceneLoader _sceneLoader;

        public LoadLevelState(GameStateMachine stateMachine, SceneLoader sceneLoader)
        {
            this._stateMachine = stateMachine;
            this._sceneLoader = sceneLoader;
        }

        public void Enter()
        {
            _sceneLoader.Load("Main");
        }

        public void Exit()
        {
            
        }
    }
}

