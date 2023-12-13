using UnityEngine;

namespace Source.Scripts.Gamemodes
{
    public class MultiplayerGameMode : IGameMode
    {
        public void Initialize()
        {
            Debug.Log("Multi");
        }
    }
}