using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float movementSpeed = 5f;
    public float jumpSpeed = 5f;
    Rigidbody2D rb;
    SpriteRenderer sprite;
    public bool onGround;
    //public bool isDead = false;



    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        DoInput();
        DoGroundCheck();

    }
    // if (!isDead) {

    //float y = Input.GetAxis("Vertical");


    void DoGroundCheck() {
        onGround = false;
        Collider2D[] colliderList = Physics2D.OverlapBoxAll(transform.position, new Vector2(0.5f, 0.5f), 0);
        foreach (Collider2D collider in colliderList) {
            if (collider.tag == "Platform" && rb.velocity.y == 0) {
                onGround = true;
            }
        }
    }

    void DoInput() {
        if (Input.GetAxis("Horizontal") > 0) {
            rb.velocity = new Vector2(movementSpeed, rb.velocity.y);
        }

        if (Input.GetAxis("Horizontal") < 0) {
            rb.velocity = new Vector2(-movementSpeed, rb.velocity.y);
        }

        if (Input.GetAxis("Horizontal") == 0) {
            rb.velocity = new Vector2(0, rb.velocity.y);


        }


        if(Input.GetKey("up")) {
            rb.velocity = new Vector2(movementSpeed, rb.velocity.y);
        }

         if (Input.GetKey("down")) {
         rb.velocity = new Vector2(-movementSpeed, rb.velocity.y);
         }

         if (Input.GetAxis("Vertical") == 0) {
         rb.velocity = new Vector2(0, rb.velocity.x);


         }


         if (Input.GetButton("Jump") && onGround) {
           rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }

    }
}
