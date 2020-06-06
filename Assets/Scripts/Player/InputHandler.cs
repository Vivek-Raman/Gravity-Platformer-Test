using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class InputHandler : MonoBehaviour
{
    private Movement movement = null;

    private void Awake()
    {
        movement = this.GetComponent<Movement>();
    }

    public void Move(InputAction.CallbackContext context)
    {
        movement.Input = context.ReadValue<Vector2>();
    }

    public void Gravity(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            movement.DetermineGravityDirection();
        }
        else if (context.phase == InputActionPhase.Canceled)
        {
            movement.SwitchGravityDirection();
        }

    }

    public void Jump(InputAction.CallbackContext context)
    {
        
    }
}