using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiflemanObjMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool canMove;

    // public override void ExtendStart() {
    //     rb = GetComponent<Rigidbody2D>();
    // }
    // public override void Move() {
    //     rb.MovePosition(transform.localScale.x == -1 ? transform.postion + Vector3.left * Time.deltaTime : transform.position + Vector3.right * Time.deltaTime);
    // }
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
        canMove = true;
    }
    private void FixedUpdate() {
        // if (canMove != Vector2.zero) {
        //     rb.velocity = new Vector2(2f, 0f);
        // }
        rb.velocity = new Vector2(2f, 0f);
    }

    // Update is called once per frame
    // void StopInTrench() {
    //     if (rb == new Vector2(-6.58, -3.12)) {
    //         rb.Rigidbody2D.velocity = Vector2.zero;
    //         rb.Rigidbody2D.angularVelocity = Vector2.zero;
    //     }
    // }
}
