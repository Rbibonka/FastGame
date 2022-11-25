using UnityEngine;

namespace Game
{
    public class PlayerStorage : MonoBehaviour
    {
        [SerializeField]
        private int coins;

        [SerializeField]
        private PlayerParametersBar playerParametersBar;

        public void SaveStorageItems()
        {
            PlayerPrefs.SetInt("Coins", coins);
        }

        public void LoadStorageItems()
        {
            coins = PlayerPrefs.GetInt("Coins");

            playerParametersBar.IncreaseCoin(coins);
        }

        public void TakeCoin(int coinNaminal)
        {
            coins += coinNaminal;

            playerParametersBar.IncreaseCoin(coinNaminal);
        }
    }
}
