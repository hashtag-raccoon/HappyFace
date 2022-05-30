using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; // 플레이어 오브젝트 선언
    Transform PT;
    void Start()
    {
        PT = player.transform;
    }
    void LateUpdate()
    {
        transform.position = new Vector3(PT.position.x, transform.position.y, transform.position.z); // 카메라 위치 플레이어에 고정
    }
}
