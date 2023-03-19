using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject eggPrefab;
    [SerializeField]
    private float eggspawnTime;
    [SerializeField]
    private Transform[] eggPoints;

    private void Awake()
    {
        StartCoroutine("SpawnEgg");
    }

    private IEnumerator SpawnEgg()
    {
        while (true)
        {
            yield return new WaitForSeconds(eggspawnTime);
        }
    }
}
