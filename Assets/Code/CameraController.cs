using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player; // �÷��̾� ������Ʈ ����
    Transform PT;
    void Start()
    {
        PT = player.transform;
    }
    void LateUpdate()
    {
        transform.position = new Vector3(PT.position.x, transform.position.y, transform.position.z); // ī�޶� ��ġ �÷��̾ ����
    }
}
