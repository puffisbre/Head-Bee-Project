using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// PlayerScript requires the GameObject to have a Rigidbody2D component

[RequireComponent(typeof(Rigidbody2D))]

public class TopDownMove : MonoBehaviour {
    Rigidbody2D rb;

    public float jumpSpeed = 5f;
    public float playerSpeed = 2f;
    public bool onGround;
    public float jumpTimer  = 0.0f;
     public float jumpTime = 2.0f;
     public bool isJumping = false;

    void Start() {
        rb = GetComponent<Rigidbody2D>();

    }

    void DoGroundCheck() {
        onGround = false;
        Collider2D[] colliderList = Physics2D.OverlapBoxAll(transform.position, new Vector2(0.5f, 0.5f), 0);
        foreach (Collider2D collider in colliderList) {
            if (collider.tag == "Platform" && rb.velocity.y == 0) {
                onGround = true;
            }
        }
    }

     void Update() {
        if (isJumping) {
            jumpTimer += Time.deltaTime;

            if (jumpTimer >= jumpTime) {
                jumpTimer = 0.0f;
                isJumping = false;
            
            }
        }
    }



    void FixedUpdate() {
        DoInput();
        Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        GetComponent<Rigidbody2D>().velocity = targetVelocity * playerSpeed;
    }

    void DoInput() {
        if (Input.GetButton("Jump") && onGround) {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
    }
}