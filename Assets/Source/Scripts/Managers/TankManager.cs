using System;
using Source.Scripts.Core;
using UnityEngine;

namespace Source.Scripts.Managers
{
    public class TankManager : MonoSingleton<TankManager>
    {
        [Serializable]
        private struct PlayerParams
        {
            public GameObject playerPrefab;
            public Transform playerStartPosition;
        }

        [SerializeField] private PlayerParams[] playersParams;

        public void SpawnTanks()
        {
            foreach (var playerParam in playersParams)
            {
                Instantiate(playerParam.playerPrefab, playerParam.playerStartPosition.position, Quaternion.identity);
            }
        }
    }
}