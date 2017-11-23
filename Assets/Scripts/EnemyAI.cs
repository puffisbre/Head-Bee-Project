﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    public Transform[] patrolPoints;
    public float speed;
    Transform currentPatrolPoint;
    int currentPatrolIndex;

    public Transform target;
    public float chaseRange;
    public TopDownMove Player;
    public HealthBar Health;
    int damage = -5;


    // Use this for initialization
    void Start() {
        currentPatrolIndex = 1;
        currentPatrolPoint = patrolPoints[currentPatrolIndex];
        Player = FindObjectOfType<TopDownMove>();
    }

    // Update is called once per frame
    void Update() {
        float distanceToTarget = Vector3.Distance(transform.position, target.position);
        if (distanceToTarget < chaseRange) {
            Vector3 targetDir = target.position - transform.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 180);

            transform.Translate(Vector3.up * Time.deltaTime * speed);

        

        }
    }
    
}
