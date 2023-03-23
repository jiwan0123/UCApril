using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    public GameObject Rabbit;
    public GameObject Fox;
    private float Dist;

    // Update is called once per frame
    void Update()
    {
        Dist = Vector3.Distance(Rabbit.transform.position, Fox.transform.position);
    }
    void LateUpdate()
    {
        print("Dist:" + Dist);
    }
}
