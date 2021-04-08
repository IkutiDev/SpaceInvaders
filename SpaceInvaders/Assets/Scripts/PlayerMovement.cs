using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float playerSpeed=10f;
    private float horizontalAxisValue=0f;
    private Rigidbody2D rigidbody2D;
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rigidbody2D.velocity = new Vector2(playerSpeed*horizontalAxisValue, 0f);
    }

    public void Move(InputAction.CallbackContext context)
    {
        horizontalAxisValue = context.ReadValue<float>();
    }
}
