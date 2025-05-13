using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController2D : MonoBehaviour
{
    [Header("Movimiento")]
    public float speed;
    private Vector2 moveInput;
    private Rigidbody2D _rigidbody2D;

    [Header("Raycast")]
    [SerializeField] private Transform _origin;
    [SerializeField] private float distance;
    [SerializeField] private LayerMask layerInteraction;
    [SerializeField] private Color colorColliding = Color.red;
    [SerializeField] private Color colorNotColliding = Color.green;
    private Vector2 lastDirection = Vector2.right;

    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
        if (moveInput != Vector2.zero)
            lastDirection = moveInput.normalized;
    }

    void FixedUpdate()
    {
        _rigidbody2D.linearVelocity = moveInput * speed;
    }
    void Update()
    {
        DrawRaycast(lastDirection);
    }

    void DrawRaycast(Vector2 vector)
    {
        RaycastHit2D hit = Physics2D.Raycast(_origin.position, vector, distance, layerInteraction);
        if (hit.collider != null)
        {
            Debug.DrawRay(_origin.position, vector * hit.distance, colorColliding);
        }
        else
        {
            Debug.DrawRay(_origin.position, vector * distance, colorNotColliding);
        }
    }
}