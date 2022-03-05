using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstecle : MonoBehaviour
{
    public float speed = -5f;
    private Rigidbody2D _rigidbody2D;

    private GameManager _gameManager;
    
    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _rigidbody2D.velocity= new Vector2(speed, _rigidbody2D.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (!other.transform.CompareTag("Player")) return;
        
        _gameManager.EndGame();
    }
}
