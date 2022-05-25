using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int speed = 6;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float playerMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerMove = speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerMove = -speed * Time.deltaTime;
        }

        this.transform.Translate(new Vector3(playerMove, 0, 0));

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (col.CompareTag("firstdoor")) // 문에 닿았을 경우
            {
                this.transform.position = col.transform.GetChild(0).transform.position; // 문 좌표로 플레이어 이동
            }
            else if (col.CompareTag("seconddoor")) // 문에 닿았을 경우
            {
                this.transform.position = col.transform.parent.transform.position; // 문 좌표로 플레이어 이동
            }
            else if (col.CompareTag("material")) // 사물에 닿았을 경우
            {
                Debug.Log("추후 추가"); // 심리게이지 처리, 게임오버 X 처리 필요
            }
        }
    }
}
