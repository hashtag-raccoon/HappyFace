using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBodyController : MonoBehaviour
{
    public GameObject Enemy;
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
            if (move_cool < 20)
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
        if (Enemy.GetComponent<EnemyController>().chase == 0)
        {
            if (col.CompareTag("firstdoor")) // 문에 닿았을 경우
            {
                if (move_cool == 0)
                {
                    Debug.Log(Enemy);
                    Enemy.transform.position = col.transform.GetChild(0).transform.position;
                    move_cool++;
                }
            }
            else if (col.CompareTag("seconddoor")) // 문에 닿았을 경우
            {
                if (move_cool == 0)
                {
                    Enemy.transform.position = col.transform.parent.transform.position;
                    move_cool++;
                }
            }
        }
        else
        {

        }
    }
}
