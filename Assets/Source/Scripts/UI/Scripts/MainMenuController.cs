using Source.Scripts.Gamemodes;
using Source.Scripts.Managers;
using UnityEngine;

namespace Source.Scripts.UI.Scripts
{
    public class MainMenuController : MonoBehaviour
    {
        [SerializeField] private GameObject mainMenuControls;
        [SerializeField] private GameObject connectionMenuControls;
        
        public void OnSplitscreenButtonClick()
        {
            GameManager.Instance.StartGame(new SplitscreenGameMode());
        }
        
        public void OnMultiplayerButtonClick()
        {
            mainMenuControls.SetActive(false);
            connectionMenuControls.SetActive(true);
        }

        public void OnQuitButtonClick()
        {
            Application.Quit();
        }
    }
}