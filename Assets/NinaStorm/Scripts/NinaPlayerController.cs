using UnityEngine;

namespace NinaStorm
{
    [RequireComponent(typeof(CharacterController))]
    public class NinaPlayerController : MonoBehaviour
    {
        public Transform cameraTransform;
        public float moveSpeed = 5.5f;
        public float rotationSpeed = 12f;
        public float gravity = -22f;
        public float jumpHeight = 1.5f;
        public float dodgeSpeed = 10f;
        public float dodgeDuration = 0.22f;

        private CharacterController controller;
        private Vector2 moveInput;
        private float verticalVelocity;
        private float dodgeTimer;
        private Vector3 dodgeDirection;

        private void Awake()
        {
            controller = GetComponent<CharacterController>();
            if (cameraTransform == null && Camera.main != null)
                cameraTransform = Camera.main.transform;
        }

        private void Update()
        {
            if (Application.isMobilePlatform)
            {
                // On mobile, drive movement with SetMoveInput from a virtual joystick.
            }
            else
            {
                moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
                if (Input.GetKeyDown(KeyCode.Space)) Jump();
                if (Input.GetKeyDown(KeyCode.LeftShift)) Dodge();
            }

            Vector3 forward = cameraTransform ? cameraTransform.forward : Vector3.forward;
            Vector3 right = cameraTransform ? cameraTransform.right : Vector3.right;
            forward.y = 0f;
            right.y = 0f;
            forward.Normalize();
            right.Normalize();

            Vector3 move = forward * moveInput.y + right * moveInput.x;
            if (move.sqrMagnitude > 1f) move.Normalize();

            if (dodgeTimer > 0f)
            {
                dodgeTimer -= Time.deltaTime;
                move = dodgeDirection;
                move *= dodgeSpeed / Mathf.Max(moveSpeed, 0.01f);
            }
            else if (move.sqrMagnitude > 0.01f)
            {
                Quaternion targetRotation = Quaternion.LookRotation(move, Vector3.up);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            }

            if (controller.isGrounded && verticalVelocity < 0f) verticalVelocity = -2f;
            verticalVelocity += gravity * Time.deltaTime;
            Vector3 velocity = move * moveSpeed;
            velocity.y = verticalVelocity;
            controller.Move(velocity * Time.deltaTime);
        }

        public void SetMoveInput(Vector2 input) { moveInput = Vector2.ClampMagnitude(input, 1f); }

        public void Jump()
        {
            if (controller.isGrounded) verticalVelocity = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        public void Dodge()
        {
            if (dodgeTimer > 0f) return;
            Vector3 forward = cameraTransform ? cameraTransform.forward : transform.forward;
            Vector3 right = cameraTransform ? cameraTransform.right : transform.right;
            forward.y = 0f; right.y = 0f;
            Vector3 direction = forward.normalized * moveInput.y + right.normalized * moveInput.x;
            if (direction.sqrMagnitude < 0.01f) direction = transform.forward;
            dodgeDirection = direction.normalized;
            dodgeTimer = dodgeDuration;
        }
    }
}