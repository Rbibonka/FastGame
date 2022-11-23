using UnityEngine;

namespace Player
{
    public class Player : Character
    {
        [SerializeField]
        private int health = 0;

        [SerializeField]
        private int damage = 0;

        protected override void Dead()
        {
            if (health <= 0)
            {
                Debug.Log("Конец!");
            }
        }

        protected override void GiveDamage()
        {
            throw new System.NotImplementedException();
        }

        protected override void RaiseLevel()
        {
            throw new System.NotImplementedException();
        }

        protected override void TakeExperience()
        {
            throw new System.NotImplementedException();
        }
    }
}

