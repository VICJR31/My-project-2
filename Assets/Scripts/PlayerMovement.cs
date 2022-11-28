using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// // (11/09/22), Alex: Don't uncomment
// Downloaded from "Input System"
// using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;

    // (11/09/22) Jose G's variables
    public Camera cam; 
    private Vector2 movement;
    private Vector2 mousePos; 

    void Update() {
        // Processing Inputs
        ProcessInputs();

        // // (11/09/22), Alex: Don't uncomment
        // Flip();             //This is for flipping player direction from Left to right and vice versa
    }

    void FixedUpdate() {
        //  Physics Calculations
        Move();
    }

    void ProcessInputs() {
        // (11/09/22) Jose G's code
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition); 

        // (11/09/22) Alex's stuff
        // // (11/09/22), Alex: Don't uncomment
        // float moveX = Input.GetAxisRaw("Horizontal");
        // float moveY = Input.GetAxisRaw("Vertical");

        // movement = new Vector2(moveX, moveY);  // TODO come back to this
    }

    void Move() {
        // (11/9/22) Jose G's code
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 40f; 
        rb.rotation = angle; 

        // (11/09/22) Alex's stuff
        // // (11/09/22), Alex: Don't uncomment
        // rb.velocity = new Vector2(movement.x * moveSpeed, movement.y * moveSpeed);
    }

// // (11/09/22), Alex: Don't uncomment

    // void Flip() {
    //     if (Keyboard.current.leftArrowKey.wasPressedThisFrame) {
    //         transform.Rotate(0, 180, 0);
    //     } 
    //     // else if(Keyboard.current.rightArrowKey.wasPressedThisFrame) {
    //     //     transform.Rotate(0, 180, 0); 
    //     // }
    // }
    
}
