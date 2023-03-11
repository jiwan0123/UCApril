using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    //[SerializeField]�� ��� public�� ������� �ʰ� ������ ����ȭ ��Ű�鼭 ����Ƽ�� �ν����͸� ����Ͽ� ������ �ٷ� �־��� �� �ִ�.
    //�ݴ�� public�� ����ϸ鼭[HideInInspector]�� ����ϸ� �ν����Ϳ��� ������ �� ������ ����� �� �� �ִ�.
    //Ŭ���� ���ٿ� [Serializable]�� ���̸� Ŭ������ü���� �ν����Ϳ� ���� ������ �� �ְԵȴ�.
    [SerializeField]
    private GameObject itemPrefab; // ������ ������
    [SerializeField]
    private float itemspawnTime; // ������ ���� �ֱ�
    [SerializeField] // ��������Ʈ ����Ʈ�� �ν����Ϳ� �ٷ� �־��� �� ����
    private Transform[] wayPoints; // ���� ���� ����Ʈ

    private void Awake()
    {
        // ������ ���� �ڷ�ƾ
        // �ڷ�ƾ�� ����Ͽ� �񵿱������� ó��
        StartCoroutine("SpawnItem");
    }

    private IEnumerator SpawnItem() //������ ���� �ڷ�ƾ �Լ� GameObject clone 
    {
        while ( true )
        {
            GameObject clone = Instantiate(itemPrefab); // clone = ������ ������
            Item item = clone.GetComponent<Item>(); // item = �� clone�� Item ������Ʈ�� �� ��
            //Item�� ������Ʈ�� ���������� setup�Լ��� ����� �� ����
            item.setup(wayPoints);
            yield return new WaitForSeconds(itemspawnTime); //������ �����ֱ� ��ŭ ��ٷȴٰ� ����� ��ȯ
        }
    }
}
