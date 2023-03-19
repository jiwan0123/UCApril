using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.AI;

public class FoxMovement : MonoBehaviour
{

    NavMeshAgent nav;

    [SerializeField]
    GameObject target;

    // Use this for initialization
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    { 
        nav.SetDestination(target.transform.position);
    }
}