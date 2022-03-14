using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed = 7.0f;
    public Rigidbody2D rigidbody2d;
    private float horizontal;
    private float vertical;

    void Start() {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update() {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate() {
        Vector2 position = rigidbody2d.position;
        position.x += speed * horizontal * Time.deltaTime;
        position.y += speed * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }
}