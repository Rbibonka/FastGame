using UnityEngine;

namespace Game 
{
    public class PlayerAnimations : MonoBehaviour
    {
        private Animator playerAnimator;

        private void Start()
        {
            playerAnimator = GetComponent<Animator>();
        }

        void Update()
        {
            if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0)
            {
                playerAnimator.SetBool("Moving", true);
            }
            else
            {
                playerAnimator.SetBool("Moving", false);
            }
        }
    }
}


