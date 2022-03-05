using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpForce = 3f;

    public float radiusCheck = 0.1f;
    public Transform groundCheckPoint;
    
    private Rigidbody2D _rigidbody2D;
    private bool _isGrounded = false;

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckPoint.position, radiusCheck);
        _isGrounded = colliders.Length > 1;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKey(KeyCode.LeftControl))
            Duck();
        else 
            Stand();
    }

    private void Jump()
    {
        if (_isGrounded == false) return;
        _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpForce ); 
    }

    private void Duck()
    {
        transform.rotation = Quaternion.Euler(0, 0, -90);
    }

    private void Stand()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
