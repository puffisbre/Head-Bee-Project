﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour {

    public Collider2D attackTrigger;
    private bool attacking = false;

    private float attackTimer = 0;
    public float attackCd = 0.3f;
    
    
    

    void Awake() {

        attackTrigger.enabled = false;

        
    }

    void Update() {

        if(Input.GetKey("f") && !attacking) {
            attacking = true;
            attackTimer = attackCd;
            

            attackTrigger.enabled = true;
        }
    
        if (attacking) {
            if (attackTimer > 0) {
                attackTimer = Time.deltaTime;
            }
            else {
                attacking = false;
                attackTrigger.enabled = false;
                
            }

            }





        }

    
    }



