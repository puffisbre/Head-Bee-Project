using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardAttackAni : MonoBehaviour {


    Animator animator;


    bool isHardAttack;
    public Collider2D HardAttack;
    // public Collider2D HitBox;
    float attackTime = 0.3f;
    float passiveTime = 0.2f;
    float attackTimer;




    SpriteRenderer mySprite;


    bool faceRight;

    bool noAttack;




    // Use this for initialization
    void Start() {

        HardAttack.enabled = false;


        StartCoroutine(DoHardAttack());






        


        }


        private void Update() {
            DoHardAttack();
       

        if (Input.GetAxis("Horizontal") < 0) {

                HardAttack.transform.localPosition = new Vector3(-0.5f, 0f, 0f);
            }


            if (Input.GetAxis("Horizontal") > 0) {

                HardAttack.transform.localPosition = new Vector3(0.1f, -0f, -0f);
            }


        }


        IEnumerator DoHardAttack() {

        yield return new WaitForSeconds(1);

        if (Input.GetButton("Fire2")) {
            animator.SetBool("isHardAttack", isHardAttack);

           

            

                isHardAttack = true;
                attackTimer = 0;
                HardAttack.enabled = true;
                // HitBox.enabled = true;
            }
           else {

             HardAttack.enabled = false;
                //HitBox.enabled = true;
            }



            if (isHardAttack || noAttack) {
                attackTimer += Time.fixedDeltaTime;
                if (attackTimer >= attackTime) {
                    isHardAttack = false;
                    noAttack = true;
                }
                if (attackTimer >= attackTime + passiveTime) {
                    noAttack = false;
                }
            }

            // if (Input.GetButton("Fire2") && !isHardAttack && !noAttack) {
            //    isHardAttack = true;
            //   attackTimer = 0;
            //  HardAttack.enabled = true;
            // HitBox.enabled = true;
            // }
            // else {

            //    HardAttack.enabled = false;
            //HitBox.enabled = true;
            // }







        }



    }


