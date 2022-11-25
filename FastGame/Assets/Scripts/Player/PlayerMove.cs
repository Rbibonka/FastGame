using UnityEngine;

namespace Game
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMove : CharacterMove
    {
        [Range(0, 20)]
        [SerializeField]
        private float characterSpeed = 5f;

        private Rigidbody2D characterBody;

        private Vector2 moveInput;

        private bool LookAtRight = true;

        private void Start()
        {
            characterBody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (!LookAtRight && moveInput.x > 0)
            {
                Flip();
            }
            else if (LookAtRight && moveInput.x < 0)
            {
                Flip();
            }
        }

        void FixedUpdate()
        {
            moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

            Moving();
        }

        protected override void Flip()
        {
            LookAtRight = !LookAtRight;

            Vector2 scaler = transform.localScale;

            scaler.x *= -1;

            transform.localScale = scaler;
        }

        protected override void Moving()
        {
            characterBody.velocity = new Vector2(moveInput.x * characterSpeed, moveInput.y * characterSpeed);
        }
    }
}