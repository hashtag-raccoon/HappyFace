using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    int speed = 2; // �� �ӵ� ��
    float enemyMove = 0; // �� �̵��ӵ�

    public GameObject player;

    int chase = 0; // �Ѱ� �ִ��� �ƴ����� üũ�� ����
    int chase_time = 0; // ������� ���� �ð�

    int dirTime = 0; // �����ֱ⸶�� �̵� ���� �����ϰ� ���� ����
    int ran = 0; // �Ϲݸ���϶� �̵� ����

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 flipMove = Vector2.zero;

        if (chase == 1)
        {
            if (player.transform.position.x > this.transform.position.x)
            {
                enemyMove = speed * Time.deltaTime; // ������ �̵�
                flipMove = Vector2.left;
                transform.localScale = new Vector2(-1f, 1f);
            }
            else
            {
                enemyMove = -speed * Time.deltaTime; // ���� �̵�
                flipMove = Vector2.right;
                transform.localScale = new Vector2(1f, 1f);
            }
        }
        else if ( chase == 0 )
        {
            if ( dirTime < 300 )
            {
                dirTime++;
            }
            else
            {
                dirTime = 0;
                ran = Random.RandomRange(-1, 2); // -1~1 ������ �� ���
                enemyMove = speed * Time.deltaTime * ran;
            }
            if ( ran == -1 )
            {
                flipMove = Vector2.right;
                transform.localScale = new Vector2(1f, 1f);
            }
            else if ( ran == 1)
            {
                flipMove = Vector2.right;
                transform.localScale = new Vector2(1f, 1f);
            }
        }

        this.transform.Translate(new Vector3(enemyMove, 0, 0)); // �� �̵�

        if (chase == 0) // ������� �ƴҶ�
        {
            speed = 2; // �⺻ �ӵ���
        }
        else if (chase == 1)
        {
            speed = 6; // ������� ���� �ӵ���
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
