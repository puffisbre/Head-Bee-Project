using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatEmUpMove : MonoBehaviour {

    public float walkMovementSpeed;
    public float attackMovementSpeed;
    public float xMin, xMax, zMin, zMax;
    Animator animator;
    float movementSpeed;
    public Vector2 jumpHeight;
    public bool facingRight;

    Rigidbody rigidBody;






	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
        movementSpeed = walkMovementSpeed;
        facingRight = true;
        animator = GetComponent<Animator>();

	}

    // Update is called once per frame
    void Update() {



       

        if (Input.GetKeyDown(KeyCode.Space))  //makes player jump
        {
            GetComponent<Rigidbody>().AddForce(jumpHeight, ForceMode.Impulse);

        }
    }


     void FixedUpdate() {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rigidBody.velocity = movement * movementSpeed;
        rigidBody.position = new Vector3
            (Mathf.Clamp(rigidBody.position.x, xMin, xMax), transform.position.y, Mathf.Clamp(rigidBody.position.z, zMin, zMax));

        
        
    }

    void Flip() {
        facingRight = !facingRight;
        Vector3 thisScale = transform.localScale;
        thisScale.x *= -1f;
        transform.localScale = thisScale;
    
    }

}
