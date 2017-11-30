using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    GameObject hero;

    // Use this for initialization
    void Start() {
        hero = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update() {
        Vector3 target;
        target = new Vector3(hero.transform.position.x, hero.transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime);
    }
}

