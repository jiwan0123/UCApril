using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePreview : MonoBehaviour
{
    public float turnSpeed = 4.0f; // ���콺 ȸ�� �ӵ�
    public float moveSpeed = 5.0f; // �̵� �ӵ�

    private float xRotate = 0.0f; // ���� ����� X�� ȸ������ ���� ���� ( ī�޶� �� �Ʒ� ���� )

    void Update()
    {
        MouseRotation();
        KeyboardMove();
    }

    // ���콺�� �����ӿ� ���� ī�޶� ȸ�� ��Ų��.
    void MouseRotation()
    {
        // �¿�� ������ ���콺�� �̵��� * �ӵ��� ���� ī�޶� �¿�� ȸ���� �� ���
        float yRotateSize = Input.GetAxis("Mouse X") * turnSpeed;
        // ���� y�� ȸ������ ���� ���ο� ȸ������ ���
        float yRotate = transform.eulerAngles.y + yRotateSize;

        // ���Ʒ��� ������ ���콺�� �̵��� * �ӵ��� ���� ī�޶� ȸ���� �� ���(�ϴ�, �ٴ��� �ٶ󺸴� ����)
        float xRotateSize = -Input.GetAxis("Mouse Y") * turnSpeed;
        // ���Ʒ� ȸ������ ���������� -45�� ~ 80���� ���� (-45:�ϴù���, 80:�ٴڹ���)
        // Clamp �� ���� ������ �����ϴ� �Լ�
        xRotate = Mathf.Clamp(xRotate + xRotateSize, -45, 80);

        // ī�޶� ȸ������ ī�޶� �ݿ�(X, Y�ุ ȸ��)
        transform.eulerAngles = new Vector3(xRotate, yRotate, 0);
    }

    // Ű������ ������ ���� �̵�
    void KeyboardMove()
    {
        // WASD Ű �Ǵ� ȭ��ǥŰ�� �̵����� ����
        Vector3 dir = new Vector3(
            Input.GetAxis("Horizontal"),
            0,
            Input.GetAxis("Vertical")
        );
        // �̵����� * �ӵ� * �����Ӵ��� �ð��� ���ؼ� ī�޶��� Ʈ�������� �̵�
        transform.Translate(dir * moveSpeed * Time.deltaTime);
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                moveSpeed = 10f;
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                moveSpeed = 5.0f;
            }
            if (Input.GetKey(KeyCode.Space))
            {
                moveSpeed = 0.5f;
            }
            if (Input.GetKeyUp(KeyCode.Space))
            {
                moveSpeed = 5.0f;
            }
        }
    }
        
}
