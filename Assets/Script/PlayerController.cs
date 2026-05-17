using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal"); // A/D
        movement.y = Input.GetAxisRaw("Vertical");   // W/S
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movement.normalized * speed;
    }
}