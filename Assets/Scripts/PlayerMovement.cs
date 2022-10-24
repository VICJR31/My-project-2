using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    private Vector2 moveDirection;

    void Update() {
        // Processing Inputs
        ProcessInputs();
    }

    void FixedUpdate() {
        //  Physics Calculations
        Move();
    }

    void ProcessInputs() {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY);  // TODO come back to this
    }

    void Move() {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
//  [SerializeField] private float speed;
//     private Rigidbody2D body;
 
//     private void Awake()
//     {
//         body = GetComponent<Rigidbody2D>();
//     }
 
//     private void Update()
//     {
//         body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);
 
//         if (Input.GetKey(KeyCode.Space))
//             body.velocity = new Vector2(body.velocity.x, speed);
//     }
}
