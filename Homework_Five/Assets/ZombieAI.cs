using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieAI : MonoBehaviour
{
    [SerializeField] Transform target;
    // [SerializeField] float chaseRange = 10f;
    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);

        if (distanceToTarget > navMeshAgent.stoppingDistance){
            GetComponent<Animator>().SetBool("attackParam", false);
            GetComponent<Animator>().SetTrigger("moveParam");
            navMeshAgent.SetDestination(target.position);
        }

        if (distanceToTarget <= navMeshAgent.stoppingDistance){
            GetComponent<Animator>().SetBool("attackParam", true);
        }
        // if(distanceToTarget <= chaseRange){
        //     navMeshAgent.SetDestination(target.position);
        // }
    }
}
