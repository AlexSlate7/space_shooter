using System;
using Code.Services.Input;

namespace Code.Infrastructure
{
    public class BootstrapState : IState
    {
        private GameStateMachine _gameStateMachine;

        public BootstrapState(GameStateMachine stateMachine)
        {
            _gameStateMachine = stateMachine;
        }

        public void Enter()
        {
            RegisterServices();
        }

        private void RegisterServices()
        {
            Game.InputService = RegisterInputService();
        }

        public void Exit()
        {
            
        }

        private static IInputService RegisterInputService()
        {
            return new InputService();
        }

    }
}

