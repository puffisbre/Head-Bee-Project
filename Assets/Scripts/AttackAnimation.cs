using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimation : MonoBehaviour {


    Animator animator;
    SpriteRenderer sprite;

    bool isAttack;
    public Collider2D HandMelee;
   // public Collider2D HitBox;
    float attackTime = 0.3f;
    float passiveTime = 0.2f;
    float attackTimer;


    

    SpriteRenderer mySprite;


    bool faceRight;

    bool noAttack;
    


    // Use this for initialization
    void Start() {
        animator = GetComponent<Animator>();
        
       mySprite = GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    void Update() {
     
    }

    void FixedUpdate() {

        DoAttacking();
        
    }


   






    void DoAttacking() {

        if (isAttack || noAttack) {
            attackTimer += Time.fixedDeltaTime;
            if (attackTimer >= attackTime) {
                isAttack = false;
                noAttack = true;
            }
            if (attackTimer >= attackTime + passiveTime) {
                noAttack = false;
            }
        }




        if (Input.GetButton("Fire1") && !isAttack && !noAttack) {
            isAttack = true;
            attackTimer = 0;
            HandMelee.enabled = true;
           // HitBox.enabled = true;
        }
        else {

            HandMelee.enabled = false;
            //HitBox.enabled = true;
        }



        animator.SetBool("isAttack", isAttack);

        if (Input.GetAxis("Horizontal") < 0) {
            
           HandMelee.transform.localPosition = new Vector3(-0.5f, 0f, 0f);
        }


        if(Input.GetAxis("Horizontal") > 0) {
           
           HandMelee.transform.localPosition = new Vector3(0.1f, -0f, -0f);
        }

    }


   





}