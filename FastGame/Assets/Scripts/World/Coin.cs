using UnityEngine;

namespace Game
{
    public class Coin : MonoBehaviour
    {
        [SerializeField]
        private int coinValue;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out PlayerStorage playerTake))
            {
                Destroy(gameObject);

                playerTake.TakeCoin(coinValue);
            }
        }
    }
}