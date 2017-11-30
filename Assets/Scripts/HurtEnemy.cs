using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour {

    public int damageToGive;

    SpriteRenderer mySprite;

    Collider2D swordcol;
    

    // Use this for initialization
    void Start () {

        swordcol = GameObject.Find("Sword").GetComponent<Collider2D>();
        
    }
	
	// Update is called once per frame
	void Update () {
        
        if(Input.GetKeyDown (KeyCode.F))
            

    }

    

    
    void OnTriggerEnter2D(Collider2D other) {

        if (other.gameObject.tag == "Enemy") {
            
                other.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);

            }

        



        }
        }
    


  



