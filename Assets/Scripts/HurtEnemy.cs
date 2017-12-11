using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour {

    public int damageToGive;

    SpriteRenderer mySprite;

    

   
    Animator animator;
    bool isAttack;

    float attackTime = 0.3f;
    float passiveTime = 0.2f;
    float attackTimer;

    bool faceRight;

    bool noAttack;
    SpriteRenderer sprite;
    // bool isIdle;
    // bool isWalking;
    // bool Fire1;


    
    void Start() {

        
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();



    }

    
    void Update() {


        

    }





    void FixedUpdate() {

        //  DoAttacking();

    }



    void OnTriggerEnter2D(Collider2D other) {




        if (other.gameObject.tag == "Enemy") {

            other.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);


        }
    }
    











    


  



        //  void DoAttacking() {
        // if (isAttack || noAttack) {
        //   attackTimer += Time.fixedDeltaTime;
        // if (attackTimer >= attackTime) {
        //      isAttack = false;
        //      noAttack = true;
        //  }
        //    if (attackTimer >= attackTime + passiveTime) {
        //    noAttack = false;
        //    }
        //  }

        //  if (Input.GetButton("Fire1") && !isAttack && !noAttack) {
        //   isAttack = true;
        // attackTimer = 0;

        //   }



        //  animator.SetBool("isAttack", isAttack);

        //}else if (Input.GetButton("Fire1") == false && !isAttack && !noAttack)

        //animator.SetBool("isAttack", false);




        //}

       



}

    






    


  



