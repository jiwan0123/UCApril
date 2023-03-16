using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    //[SerializeField]의 경우 public을 사용하지 않고 정보를 은닉화 시키면서 유니티의 인스펙터를 사용하여 정보를 바로 넣어줄 수 있다.
    //반대로 public을 사용하면서[HideInInspector]를 사용하면 인스펙터에서 적용할 수 없도록 만들어 줄 수 있다.
    //클래스 윗줄에 [Serializable]을 붙이면 클래스객체에도 인스펙터에 값을 지정할 수 있게된다.
    [SerializeField]
    private GameObject itemPrefab; // 아이템 프리팹
    [SerializeField]
    private float itemspawnTime; // 아이템 생성 주기
    [SerializeField] // 웨이포인트 리스트를 인스펙터에 바로 넣어줄 수 있음
    private Transform[] wayPoints; // 현재 맵의 포인트

    private void Awake()
    {
        // 아이템 생성 코루틴
        // 코루틴을 사용하여 비동기적으로 처리
        StartCoroutine("SpawnItem");
    }

    private IEnumerator SpawnItem() //아이템 생성 코루틴 함수
    {
        while ( true )
        {
            GameObject clone = Instantiate(itemPrefab); // clone = 아이템 프리팹
            Item item = clone.GetComponent<Item>(); // item = 위 clone에 Item 컴포넌트를 준 것
            //Item의 컴포넌트를 가져왓으니 setup함수를 사용할 수 있음
            item.Setup(wayPoints);
            yield return new WaitForSeconds(itemspawnTime); //아이템 생성주기 만큼 기다렸다가 제어권 반환
        }
    }
}
