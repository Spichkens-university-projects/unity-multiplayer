using UnityEngine;

namespace Source.Scripts.Gamemodes
{
    public class SplitscreenGameMode : GameModeBase, IGameMode
    {
        public new void OnGameStart()
        {
            base.OnGameStart();
            Debug.Log("Splitscreen mode started");
        }
    }
}