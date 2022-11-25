using UnityEngine.UI;
using UnityEngine;

namespace Game
{
    public class PlayerParametersBar : MonoBehaviour
    {
        [SerializeField]
        private Text playerHealthsText;

        [SerializeField]
        private Text playerCoinsText;

        private int coinValue;

        private int healthValue;

        private void UpdateBar()
        {
            playerCoinsText.text = $"x {coinValue}";

            playerHealthsText.text = $"x {healthValue}";
        }

        public void IncreaseCoin(int coinNaminal)
        {
            coinValue += coinNaminal;

            UpdateBar();
        }

        public void IncreaseHealth(int health)
        {
            healthValue += health;

            UpdateBar();
        }
    }
}
