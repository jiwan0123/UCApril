using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ColliderFollow : MonoBehaviour
{
    public float chaseRadius = 50f;

    private NavMeshAgent nav;
    private GameObject target;

    private void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.FindWithTag("Rabbit");
    }

    private void Update()
    {
        Collider[] cols = Physics.OverlapSphere(transform.position, chaseRadius);

        // Rabbit이 Fox 반경에서 벗어나면 Fox가 멈추게끔 하는 방법 bool 함수
        bool rabbitInRange = false; // Rabbit이 반경 안에 있는지 여부를 저장하는 변수
        foreach (Collider col in cols)
        {
            if (col.CompareTag("Rabbit"))
            {
                rabbitInRange = true;
                nav.SetDestination(target.transform.position);
            }
        }

        // Rabbit이 반경 안에 없으면 Fox가 멈춤
        if (!rabbitInRange)
        {
            nav.ResetPath();
        }
    }
}
