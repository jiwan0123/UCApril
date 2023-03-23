using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyMovement : MonoBehaviour
{
    
    private GameObject Target;
    public float UpdateSpeed = 0.1f;

    private NavMeshAgent Agent;

    private void Awake()
    {
        Agent = GetComponent<NavMeshAgent>();
        
    }

    private void Start()
    {
        StartCoroutine(FollowTarget());
        Debug.Log(Vector3.Distance(transform.position, Target.transform.position));
    }

    private IEnumerator FollowTarget()
    {
        WaitForSeconds wait = new WaitForSeconds(UpdateSpeed); 

        while (enabled)
        {
            if(Vector3.Distance(transform.position, Target.transform.position)<10)
            {
                Agent.speed = 3.5f;
                Agent.SetDestination(Target.transform.position);
            }
            else
            {
                Agent.speed = 0f;
            }
            yield return wait;
        }
    }

    public void TargetSet(GameObject Target)
    {
        this.Target = Target;
    }
}