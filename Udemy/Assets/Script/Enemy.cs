using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform targetPosition;
    private NavMeshAgent agent;
 
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
 
    // Update is called once per frame
    void Update()
    {
        agent.destination = targetPosition.position;
    }
}
