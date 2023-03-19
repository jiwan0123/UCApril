using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    private int foxPointCount; //여우의 포인트 개수
    private Transform[] foxPoints;// 여우포인트 정보
    private int currentIndex = 0;//목표인덱스

    private EnemyMovement enemyMovement;
    [SerializeField]
    private GameObject Target;
    
    public void Setup(Transform[] foxPoints, GameObject Target)
    {


        enemyMovement = GetComponent<EnemyMovement>();

        this.Target = Target;
        enemyMovement.TargetSet(this.Target);
        //enemyMovement.Target = this.Target;


        currentIndex = Random.Range(0, foxPoints.Length);

        //여우의 생성될 포인트 정보 설정
        foxPointCount = foxPoints.Length;
        this.foxPoints = new Transform[foxPointCount]; //포인트 개수만큼 메모리 공간 생성
        this.foxPoints = foxPoints;

        

        //여우의 위치를 여우포인트 위치로 설정
        transform.position = foxPoints[currentIndex].position;

    }
}
