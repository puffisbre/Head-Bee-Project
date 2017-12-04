using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

// PlayerScript requires the GameObject to have a Rigidbody2D component

[RequireComponent(typeof(Rigidbody2D))]

public class TopDownMove : MonoBehaviour {
    Rigidbody2D rb;

    public float jumpSpeed = 5f;
    public float playerSpeed = 2f;
    public bool onGround;
    bool isIdle;

    SpriteRenderer sprite;
    Animator animator;




    // public float jumpTimer  = 0.0f;
    //public float jumpTime = 2.0f;
    //public bool isJumping = false;







    void Start() {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    //random shit jag ska titta på sen
   

     void Update() {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        //transform.Translate(horizontal * playerSpeed * Time.deltaTime, vertical * playerSpeed * Time.deltaTime, 0f, Space.World);

        //Melee Attack that doesn't work atm

      // if (Input.GetButtonDown("Fire1")) {
           // GameObject[] hitObjects = Physics2D.OverlapCircleAll (transform.position, 1.0);
        }

        
    
    void FixedUpdate() {

        //Movement

        DoInput();
        Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        GetComponent<Rigidbody2D>().velocity = targetVelocity * playerSpeed;
        
        
    }

    //animation bools for idle and walking right now.
    void DoInput() {

        if (Input.GetAxis("Horizontal")  > 0) {
            sprite.flipX = false;
            animator.SetBool("isWalking", true);
            animator.SetBool("isIdle", false);

        }
        if (Input.GetAxis("Horizontal") < 0) {
            sprite.flipX = true;
            animator.SetBool("isWalking", true);
            animator.SetBool("isIdle", false);
        }
        if (Input.GetAxis("Horizontal") == 0) {
            
            animator.SetBool("isWalking", false);
            animator.SetBool("isIdle", true);
        }

        if (Input.GetAxis("Vertical") > 0) {
            animator.SetBool("isWalking", true);
            animator.SetBool("isIdle", false);
        }

        if (Input.GetAxis("Vertical") < 0) {
            
            animator.SetBool("isWalking", true);
            animator.SetBool("isIdle", false);
        }

        if (Input.GetAxis("Vertical") == 0) {
            
            animator.SetBool("isWalking", false);
            animator.SetBool("isIdle", true);
        }



    }
     

    

    
    
    }

    

        
    













