using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {
    public int MaxHealth;
    public int CurrentHealth;
    Animator animator;
    bool isAiDead;

    // Use this for initialization
    void Start() {

        CurrentHealth = MaxHealth;
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update() {
        if (CurrentHealth <= 0) {
            gameObject.SetActive(false);
            Destroy(gameObject);
           // animator.SetBool("isAiDead", true);
       // }else {

          //  animator.SetBool("isAiDead", false);
        }
        

            
        }

        

    

    public void HurtEnemy(int damageToGive) {
        CurrentHealth -= damageToGive;

    }

    public void SetMaxHealth() {

        CurrentHealth = MaxHealth;
    }
}