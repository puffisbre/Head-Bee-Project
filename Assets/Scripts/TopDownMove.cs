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


    

    


    // public float jumpTimer  = 0.0f;
    //public float jumpTime = 2.0f;
    //public bool isJumping = false;







    void Start() {
        rb = GetComponent<Rigidbody2D>();
       

    }
    //random shit jag ska titta på sen
   

     void Update() {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        //transform.Translate(horizontal * playerSpeed * Time.deltaTime, vertical * playerSpeed * Time.deltaTime, 0f, Space.World);

        //Melee Attack

      // if (Input.GetButtonDown("Fire1")) {
           // GameObject[] hitObjects = Physics2D.OverlapCircleAll (transform.position, 1.0);
        }

        
    
    void FixedUpdate() {

        //Movement

        DoInput();
        Vector2 targetVelocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        GetComponent<Rigidbody2D>().velocity = targetVelocity * playerSpeed;
    }

    void DoInput() {

        //if (Input.GetButtonDown("360_XButton")){
        //Debug.Log("X Button!");
    //}
    }

    

        
    }













