using UnityEngine.SceneManagement;

namespace Source.Scripts.Gamemodes
{
    public class SplitscreenGameMode : IGameMode
    {
        public void Initialize()
        {
            SceneManager.LoadScene("Gameplay");
        }
    }
}