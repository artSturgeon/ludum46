using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyController : MonoBehaviour
{

    public NavMeshAgent agent;
    public Transform creature;


    private void Update()
    {

        agent.SetDestination(creature.position);

    }



}
