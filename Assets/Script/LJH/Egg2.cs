using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg2 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")   // 충돌한 오브젝트가 토끼인 경우
        {
            transform.parent = collision.transform; // 알 오브젝트의 부모를 충돌한 토끼 오브젝트로 변경
            GetComponent<MeshRenderer>().enabled = false; // 알 오브젝트의 Mesh Renderer 컴포넌트 비활성화
            Destroy(GetComponent<SphereCollider>()); // 알 오브젝트의 SphereCollider 파괴
            Destroy(GetComponent<Rigidbody>()); // 알 오브젝트의 Rigidbody 컴포넌트 파괴

        }
    }
}