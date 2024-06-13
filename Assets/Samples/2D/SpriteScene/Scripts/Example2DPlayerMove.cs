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
        // ���͂��擾
        float moveX = Input.GetAxis("Horizontal");

        // ���͂��i�[
        _moveDirection = new Vector2(moveX, _rb.velocity.y);
    }

    void FixedUpdate()
    {
        // �ړ�����
        _rb.velocity = new Vector2(_moveDirection.x * speed, _rb.velocity.y);
    }
}
