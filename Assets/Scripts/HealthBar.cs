using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

    public int MaxHealth = 100;
    public int currentHealth;

    // Use this for initialization
    void Start() {
        MaxHealth = MaxHealth;
    }

    public void TakeDamage(int damage) {
        MaxHealth -= damage;
    }
}
