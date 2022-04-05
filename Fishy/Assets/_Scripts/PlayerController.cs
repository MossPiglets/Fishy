using System;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] private float speed = 7.0f;
    public Rigidbody2D rigidbody2d;
    private float horizontal;
    private float vertical;
    private bool facingLeft = true;

    void Start() {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update() {
        horizontal = Input.GetAxis("Horizontal");
        if (horizontal > 0 && facingLeft) {
            Flip();
            facingLeft = false;
        }

        if (horizontal < 0 && !facingLeft) {
            Flip();
            facingLeft = true;
        }
        vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate() {
        Vector2 position = rigidbody2d.position;
        position.x += speed * horizontal * Time.deltaTime;
        position.y += speed * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }

    void Flip() {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}