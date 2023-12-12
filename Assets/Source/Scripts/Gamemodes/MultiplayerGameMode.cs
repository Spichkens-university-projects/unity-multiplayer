using UnityEngine;

namespace Source.Scripts.Gamemodes
{
    public class MultiplayerGameMode : GameModeBase, IGameMode
    {
        public new void OnGameStart()
        {
            base.OnGameStart();
            Debug.Log("Multiplayer mode started");
        }
    }
}