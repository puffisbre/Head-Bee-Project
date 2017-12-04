using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimation : MonoBehaviour {


    Animator animator;
    SpriteRenderer sprite;

    bool isAttack;

    float attackTime = 0.3f;
    float passiveTime = 0.2f;
    float attackTimer;

    bool noAttack;

    // Use this for initialization
    void Start() {
        animator = GetComponent<Animator>();


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

        }



        animator.SetBool("isAttack", isAttack);
    }
}
