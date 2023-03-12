using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_Move : MonoBehaviour
{
    public int Speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Speed++;
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            Speed--;
        }
    }
}
