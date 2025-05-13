using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController2D : MonoBehaviour
{
    private Rigidbody2D _rigidbody2d;
    public Vector2 moveInput;
    public float speed;

    void Awake()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        _rigidbody2d.linearVelocity = moveInput * speed;
    }
}
