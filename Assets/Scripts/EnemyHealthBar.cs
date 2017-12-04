using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour {

    EnemyHealthManager health;
    Slider slider;

    // Use this for initialization
    void Start() {
        GameObject BlackBee = GameObject.FindGameObjectWithTag("Enemy");
        health = BlackBee.GetComponent<EnemyHealthManager>();
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update() {
        slider.value = (float)health.CurrentHealth / (float)health.MaxHealth;
    }
}
