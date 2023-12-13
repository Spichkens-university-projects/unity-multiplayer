using Source.Scripts.Core;
using Source.Scripts.Gamemodes;

namespace Source.Scripts.Managers
{
    public class GameManager : MonoSingleton<GameManager>
    {
        public IGameMode CurrentGamemode { get; set; }

        public void StartGame(IGameMode gameMode)
        {
            CurrentGamemode = gameMode;
            CurrentGamemode.Initialize();
        }

    }
}