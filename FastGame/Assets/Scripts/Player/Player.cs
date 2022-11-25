using UnityEngine;

namespace Game
{
    public class Player : Character
    {
        [Header("Properties player")]
        [SerializeField]
        private int healths;

        [SerializeField]
        private int damage;

        [SerializeField]
        private float experience;

        [Header("Support class")]
        [SerializeField]
        private PlayerParametersBar playerParametersBar;

        public void TakeDamage(int damage)
        {
            healths -= damage;

            if (healths <= 0)
            {
                Dead();
            }
        }

        private void Start()
        {
            playerParametersBar.IncreaseHealth(healths); //Add health value in the text UI 
        }

        protected override void Dead()
        {
            Debug.Log("Конец!");
        }

        protected override void RaiseLevel()
        {
            Debug.Log("Уровень повышен!");
        }

        protected override void TakeExperience(float experience)
        {
            Debug.Log("Расту!");
        }
    }
}

