/*using UnityEngine;

namespace Inputs
{
    [RequireComponent(typeof(Player))]
    public class PlayerInputReader : MonoBehaviour
    {
        private Player _player;

        private void Awake()
        {
            _player = GetComponent<Player>();
        }

        public void OnMove(InputAction.CallbackContext context)
        {
            _player.MovementComponent.Direction = context.ReadValue<float>();
        }

        public void OnJump(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                _player.MovementComponent.IsJumpPressing = true;
            }

            if (context.canceled)
            {
                _player.MovementComponent.IsJumpPressing = false;
                _player.MovementComponent.JumpButtonWasPressed = false;
            }
        }  */