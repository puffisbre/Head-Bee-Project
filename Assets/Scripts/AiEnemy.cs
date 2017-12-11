using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiEnemy : MonoBehaviour {

    public Transform target;//set target from inspector instead of looking in Update
    public float speed = 3f;
    public int giveDamage;


    void Start() {

    }

    void Update() {

        //rotate to look at the player
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);//correcting the original rotation


        //move towards the player
        if (Vector3.Distance(transform.position, target.position) > 0.5f) {//move if distance from target is greater than 1
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }

    }


    void OnTriggerEnter2D(Collider2D other) {




        if (other.gameObject.tag == "Player") {

            other.GetComponent<PlayerHealthManager>().HurtPlayer(giveDamage);


        }
    }
}





