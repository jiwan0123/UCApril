using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject rabbitPrefab; //토끼 프리팹
    [SerializeField]
    private Transform[] nestPoints; //토끼 생성될 둥지포인트 정보

    private void Awake()
    {
        SpawnRabbit(); //게임 시작시 토끼 스폰함수 추후 if문으로 처리 해야함
    }

    private void SpawnRabbit() 
    {
        GameObject firstRabbit = Instantiate(rabbitPrefab);
        Rabbit rabbit = firstRabbit.GetComponent<Rabbit>();

        rabbit.Setup(nestPoints);
    }
}
