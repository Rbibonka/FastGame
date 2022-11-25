using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        private Player player;

        [SerializeField]
        private PlayerStorage playerStorage;

        private void OnApplicationQuit()
        {
            playerStorage.SaveStorageItems();
        }

        private void Start()
        {
            playerStorage.LoadStorageItems();
        }
    }
}

