using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {

    public int giveDamage;



    // Use this for initialization
    void OnTriggerEnter2D(Collider2D other) {




        if (other.gameObject.tag == "Player") {

            other.GetComponent<PlayerHealthManager>().HurtPlayer(giveDamage);


        }
    }
}