using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example2DPlayerMove : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f; 

    private Rigidbody2D _rb;

    private Vector2 _moveDirection;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // “ü—Í‚ğæ“¾
        float moveX = Input.GetAxis("Horizontal");

        // “ü—Í‚ğŠi”[
        _moveDirection = new Vector2(moveX, _rb.velocity.y);
    }

    void FixedUpdate()
    {
        // ˆÚ“®ˆ—
        _rb.velocity = new Vector2(_moveDirection.x * speed, _rb.velocity.y);
    }
}
