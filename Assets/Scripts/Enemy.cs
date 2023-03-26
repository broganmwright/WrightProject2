using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Animator anim;
    public NavMeshAgent navAgent;
    public Transform[] points;

    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, points.Length);
        navAgent.SetDestination(points[rand].position);
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Walk", true);
        anim.SetBool("Idle", false);
        if (navAgent.remainingDistance <= navAgent.stoppingDistance)
        {
            int rand = Random.Range(0, points.Length);
            navAgent.SetDestination(points[rand].position);
        }
    }
}
