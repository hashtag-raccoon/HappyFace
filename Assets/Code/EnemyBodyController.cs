using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyBodyController : MonoBehaviour
{
    public GameObject Enemy;
    public GameObject player;
    public int move_cool = 0;

    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.FindGameObjectWithTag("enemy");
    }

    // Update is called once per frame
    void Update()
    {
        if (move_cool > 0)
        {
            if (move_cool < 300)
            {
                move_cool++;
            }
            else
            {
                move_cool = 0;
            }
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("class"))
        {
            Enemy.GetComponent<EnemyController>().classA = true;
            Enemy.GetComponent<EnemyController>().classB = false;
        }
        else if (col.CompareTag("class2"))
        {
            Enemy.GetComponent<EnemyController>().classB = true;
            Enemy.GetComponent<EnemyController>().classA = false;
        }
        if (Enemy.GetComponent<EnemyController>().chase == 0)
        {
            if (col.CompareTag("firstdoor")) // 문에 닿았을 경우
            {
                Debug.Log("충돌중인 문 : " + col);
                if (move_cool == 0)
                {
                    Enemy.transform.position = col.transform.GetChild(0).transform.position;
                    move_cool++;
                }
            }
            else if (col.CompareTag("seconddoor")) // 문에 닿았을 경우
            {
                Debug.Log("충돌중인 문 : " + col);
                if (move_cool == 0)
                {
                    Enemy.transform.position = col.transform.parent.transform.position;
                    move_cool++;
                }
            }
        }
        else
        {
            if (col == Enemy.GetComponent<EnemyController>().chase_door) // 목표 문에 닿았을 경우
            {
                if (player.transform.position.y != Enemy.transform.position.y)
                {
                    if (Enemy.GetComponent<EnemyController>().chase_door.CompareTag("firstdoor"))
                    {
                        Enemy.transform.position = col.transform.GetChild(0).transform.position;
                    }
                    else if (Enemy.GetComponent<EnemyController>().chase_door.CompareTag("seconddoor"))
                    {
                        Enemy.transform.position = col.transform.parent.transform.position;
                    }
                }
            }
        }
        if (col.gameObject.name.Equals("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
