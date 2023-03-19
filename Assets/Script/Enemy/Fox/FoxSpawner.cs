using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject foxPrefab; //여우 프리팹
    [SerializeField]
    private Transform[] foxPoints; //여우 생성될 여우의 포인트 정보

    private GameObject fox;

    private void Awake()
    {
        SpawnFox(); //게임 시작시 여우 스폰함수 추후 if문으로 처리 해야함
    }

    private void SpawnFox()
    {
        GameObject firstFox = Instantiate(foxPrefab);
        Fox fox = firstFox.GetComponent<Fox>();

        fox.Setup(foxPoints);
    }


}
