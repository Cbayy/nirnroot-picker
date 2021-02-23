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
            if(distance <= agent.stoppingDistance){
                FaceTarget();
            }
        }
    }

    void FaceTarget(){
        Vector3 direction = (player.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    void OnDrawGizmosSelected(){
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}