using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    public Transform player;

    //����ī�޶� �÷��̾� ���ʿ� ��ġ
    private void Update()
    {
        transform.position = player.transform.position + new Vector3(0,3,-6);  // maincamera x,y,z ��ǥ �̵�
                                                                               // �÷��̾� ���󰡴� ����ī�޶� 
    }
}
