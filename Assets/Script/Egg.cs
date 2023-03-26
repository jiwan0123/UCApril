using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    private int eggPointCount;
    private Transform[] eggPoints;
    private int currentIndex;

    public void Setup(Transform[] eggPoints)
    {
        eggPointCount = eggPoints.Length;
        this.eggPoints = new Transform[eggPointCount];
        this.eggPoints = eggPoints;

        transform.position = eggPoints[currentIndex].position;
    }
}
