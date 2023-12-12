using Source.Scripts.Gamemodes;
using Source.Scripts.Managers;
using UnityEngine;

namespace Source.Scripts.UI.MainMenu
{
    public class MainMenuController : MonoBehaviour
    {
        public void OnSingleplayerButtonClick()
        {
            GameManager.Instance.StartGame(new SingleplayerGameMode());
        }
        
        public void OnMultiplayerButtonClick()
        {
            GameManager.Instance.StartGame(new MultiplayerGameMode());
        }
        
        public void OnSplitscreenButtonClick()
        {
            GameManager.Instance.StartGame(new SplitscreenGameMode());
        }

        public void OnQuitButtonClick()
        {
            Application.Quit();
        }
    }
}