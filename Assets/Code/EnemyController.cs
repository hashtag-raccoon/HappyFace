using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    int speed = 2; // 적 속도 값
    float enemyMove; // 적 이동속도

    public GameObject player;

    int chase = 0; // 쫓고 있는지 아닌지를 체크할 변수
    int chase_time = 0; // 추적모드 종료 시간

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 flipMove = Vector2.zero;

        if (player.transform.position.x > this.transform.position.x)
        {
            enemyMove = speed * Time.deltaTime; // 오른쪽 이동
            flipMove = Vector2.left;
            transform.localScale = new Vector2(-1f, 1f);
        }
        else
        {
            enemyMove = -speed * Time.deltaTime; // 왼쪽 이동
            flipMove = Vector2.right;
            transform.localScale = new Vector2(1f, 1f);
        }

        this.transform.Translate(new Vector3(enemyMove, 0, 0)); // 적 이동

        if (chase == 0) // 추적모드 아닐때
        {
            speed = 2; // 기본 속도값
        }
        else if (chase == 1)
        {
            speed = 6; // 추적모드 전용 속도값
            if (chase_time == 0)
            {
                chase = 0;
            }
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            chase_time = 60;
            chase = 1;
        }
        else
        {
            if (chase_time > 0)
            {
                chase_time--;
            }
        }
    }
}
