using Code.Services.Input;
using UnityEngine;

namespace Code.Infrastructure
{
    public class Game
    {
        public static IInputService InputService;

        public Game()
        {
            RegisterInputService();
        }

        private void RegisterInputService()
        {
            InputService = new InputService();
        }
    }
}