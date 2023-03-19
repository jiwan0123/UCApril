using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : MonoBehaviour
{
    private int nestPointCount; //둥지포인트 개수
    private Transform[] nestPoints;// 둥지포인트 정보
    private int currentIndex = 0;//목표인덱스

    public void Setup(Transform[] nestPoints)
    {
        //토끼의 생성될 포인트 정보 설정
        nestPointCount = nestPoints.Length;
        this.nestPoints = new Transform[nestPointCount]; //포인트 개수만큼 메모리 공간 생성
        this.nestPoints = nestPoints;


        //토끼의 위치를 둥지포인트 위치로 설정
        transform.position = nestPoints[currentIndex].position;


    }
}
