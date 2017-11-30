using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

    public Transform BlackBee;


    void Start() {
        for (int i = 0; i < 10; i++) {
            Instantiate(BlackBee, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        }
    }
}