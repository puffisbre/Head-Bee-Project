using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour {

    public int  maxPlayerHealth;

    public static int playerHealth;

   

    


     void Start() {

        
        playerHealth = maxPlayerHealth;
        
        
    }

     void Update() {

    //if(playerHealth <= 0) {

            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //}

        
    }

    public static void HurtPlayer (int damageToGive) {

        playerHealth -= damageToGive;
    }


    public void FullHealth() {

        playerHealth = maxPlayerHealth;


    }


}

