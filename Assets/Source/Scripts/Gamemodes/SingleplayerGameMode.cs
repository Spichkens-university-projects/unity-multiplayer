using UnityEngine;

namespace Source.Scripts.Gamemodes
{
    public class SingleplayerGameMode : GameModeBase, IGameMode
    {
        public new void OnGameStart()
        {
            base.OnGameStart();
            Debug.Log("Singleplayer mode started");
        }
    }
}