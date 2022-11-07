using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public Camera cam; 

    private Vector2 movement;
    private Vector2 mousePos; 

    void Update() {
        // Processing Inputs
        ProcessInputs();
    }

    void FixedUpdate() {
        //  Physics Calculations
        Move();
    }

    void ProcessInputs() {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition); 

        // float moveX = Input.GetAxisRaw("Horizontal");
        // float moveY = Input.GetAxisRaw("Vertical");

        // movement = new Vector2(moveX, moveY);  // TODO come back to this
    }

    void Move() {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f; 
        rb.rotation = angle; 

        //rb.velocity = new Vector2(movement.x * moveSpeed, movement.y * moveSpeed);
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
