using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{

    public float lookRadius = 100f;
    public Transform player;
    NavMeshAgent agent;
    
    void Start(){
        agent = GetComponent<NavMeshAgent>();
    }

    void Update(){
        float distance = Vector3.Distance(player.position, transform.position);

        if(distance <= lookRadius){
            agent.SetDestination(player.position);
        }
    }

    void OnDrawGizmosSelected(){
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}