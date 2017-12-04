using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour {

    public int damageToGive;

    SpriteRenderer mySprite;

    Collider2D swordcol;

    Animator animator;
    bool isAttack;

    float attackTime = 0.3f;
    float passiveTime = 0.2f;
    float attackTimer;
    
    bool noAttack;
    SpriteRenderer sprite;




    // Use this for initialization
    void Start () {

        swordcol = GameObject.Find("Sword").GetComponent<Collider2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();

    }
	
	// Update is called once per frame
	void Update () {
        
       
            

    }

    void FixedUpdate() {

        DoAttacking();

    }



    void OnTriggerEnter2D(Collider2D other) {

        if (other.gameObject.tag == "Enemy") {
            
                other.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);

            }

        



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
            
           
            
        }

        animator.SetBool("isAttack", isAttack);
    }

    void DoInput() {

        if (Input.GetAxis("Horizontal") > 0) {
            sprite.flipX = false;

        }
        if (Input.GetAxis("Horizontal") < 0) {
            sprite.flipX = true;
        }

    }






}
    


  



