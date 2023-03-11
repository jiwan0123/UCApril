using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private int wayPointCount; //����Ʈ ����
    private Transform[] wayPoints;// ����Ʈ ����
    private int currentIndex = 0;//��ǥ�ε��� (�������� ������ ����Ʈ����Ʈ �� �ε����� �������� ������ ������ ������ ����) //�������� ������ ��ġ�� �������� �ʱ����� ���� ����

    public void setup(Transform[] wayPoints)
    {
        //�������� ������ ����Ʈ ���� ����
        wayPointCount = wayPoints.Length;
        this.wayPoints = new Transform[wayPointCount]; //����Ʈ ������ŭ �޸� ���� ����
        this.wayPoints = wayPoints;

        //currentIndex(��ǥ�ε���)�� �������� ����
        currentIndex = Random.Range(0, wayPointCount);
        
        //�������� ��ġ�� ��������Ʈ ��ġ�� ����
        transform.position = wayPoints[currentIndex].position;

        //���� �ڷ�ƾ ����Ͽ� ������ ȿ���� �����ϸ� �ɵ���
    }
}
