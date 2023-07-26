using Code.Services.Input;
using UnityEngine;

namespace Code.Infrastructure
{
    public class Game
    {
        public static IInputService InputService;
        public GameStateMachine StateMachine;

        public Game()
        {
            StateMachine = new GameStateMachine();
        }

    }
}