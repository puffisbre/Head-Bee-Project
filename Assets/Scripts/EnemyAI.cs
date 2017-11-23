using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

    public Transform[] patrolPoints;
    public float speed;
    Transform currentPatrolPoint;
    int currentPatrolIndex;

    public Transform target;
    public float chaseRange;



	// Use this for initialization
	void Start () {
        currentPatrolIndex = 0;
        currentPatrolPoint = patrolPoints[currentPatrolIndex];
	}
	
	// Update is called once per frame
	void Update () {
        float distanceToTarget = Vector3.Distance(transform.position, target.position);
        if(distanceToTarget < chaseRange) {
            Vector3 targetDir = target.position - transform.position;

        }
		
	}
}
