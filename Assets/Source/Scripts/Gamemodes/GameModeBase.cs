using UnityEngine.SceneManagement;

namespace Source.Scripts.Gamemodes
{
    public class GameModeBase
    {
        protected void OnGameStart()
        {
            SceneManager.LoadScene("Gameplay");
        }
    }
}