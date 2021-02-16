using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public NavMeshAgent agent;


    private void Awake(){
        player = GameObject.Find("First Person Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }
}
