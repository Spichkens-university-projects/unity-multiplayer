using kcp2k;
using Mirror;
using Source.Scripts.Gamemodes;
using Source.Scripts.Managers;
using TMPro;
using UnityEngine;

namespace Source.Scripts.UI.Scripts
{
    public class ConnectionMenuController : MonoBehaviour
    {
        [SerializeField] private TMP_InputField addressInput;
        [SerializeField] private TMP_InputField portInput;

        public void OnAddressInputChange()
        {
            NetworkManager.singleton.networkAddress = addressInput.text;
        }
        
        public void OnPortInputChange()
        {
            ushort.TryParse(portInput.text, out ushort val);
            NetworkManager.singleton.GetComponent<KcpTransport>().port = val;
        }

        public void StartHost()
        {
            NetworkManager.singleton.StartHost();
            GameManager.Instance.StartGame(new MultiplayerGameMode());
        }
        
        public void StartClient()
        {
            NetworkManager.singleton.StartClient();
            GameManager.Instance.StartGame(new MultiplayerGameMode());
        }
        
        public void StartServer()
        {
            NetworkManager.singleton.StartServer();
            GameManager.Instance.StartGame(new MultiplayerGameMode());
        }
    }
}