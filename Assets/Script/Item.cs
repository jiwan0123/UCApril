using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private int wayPointCount; //포인트 개수
    private Transform[] wayPoints;// 포인트 정보
    private int currentIndex = 0;//목표인덱스 (아이템이 생성될 포인트리스트 중 인덱스를 랜덤으로 돌려서 아이템 생성할 예정)

    public void Setup(Transform[] wayPoints)
    {
        //아이템의 생성될 포인트 정보 설정
        wayPointCount = wayPoints.Length;
        this.wayPoints = new Transform[wayPointCount]; //포인트 개수만큼 메모리 공간 생성
        this.wayPoints = wayPoints;

        //currentIndex(목표인덱스)를 랜덤으로 설정
        currentIndex = Random.Range(0, wayPointCount);
        
        //아이템의 위치를 웨이포인트 위치로 설정
        transform.position = wayPoints[currentIndex].position;

        
    }
}

