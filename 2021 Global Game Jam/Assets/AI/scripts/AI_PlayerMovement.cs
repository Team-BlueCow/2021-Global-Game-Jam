using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AI_PlayerMovement : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] float moveSpeed = 5f;

    private InputController controls;
    Vector2 moveDirection;

    void Awake()
    {
        controls = new InputController();
        controls.Movement.Move.performed += ctx => OnMove(ctx.ReadValue<Vector2>());
        controls.Movement.Move.canceled += ctx => OnStopMove();
    }
    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    void Update()
    {
        Vector2 movement = moveDirection;

        GetComponent<Rigidbody2D>().AddForce(moveDirection);
        
    }

    void OnMove(Vector2 direction)
    {
        moveDirection = direction;
    }

    void OnStopMove()
    {
        moveDirection = new Vector2(0, 0);
    }
}
