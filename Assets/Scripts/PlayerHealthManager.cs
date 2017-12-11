using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour {
    public Image currentHealthBar;
    public Text ratioText;
    public float playerMaxHealth = 100;
    public float playerCurrentHealth = 100;

	// Use this for initialization
	void Start () {

      //  playerCurrentHealth = playerMaxHealth;
        UpdateHpBar();

    }
	
	// Update is called once per frame
	void Update () {

        
        if (playerCurrentHealth <= 0) {
            gameObject.SetActive(false);
        }

        

	}

     void FixedUpdate() {

        


    }


    private void UpdateHpBar() {

        float ratio = playerCurrentHealth / playerMaxHealth;
        currentHealthBar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        ratioText.text = (ratio * 100).ToString("0") + '%';



    }



    public void HurtPlayer (float giveDamage) {
       playerCurrentHealth -= giveDamage;
        UpdateHpBar();


    }

    public void SetToMaxHealth() {

        playerCurrentHealth = playerMaxHealth;
    }

    





}
