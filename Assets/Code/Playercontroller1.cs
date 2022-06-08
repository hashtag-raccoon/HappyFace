using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller1 : MonoBehaviour
{
    int speed = 6;

    public bool classA = false;
    public bool classB = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float playerMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerMove = speed * Time.deltaTime;
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerMove = -speed * Time.deltaTime;
            transform.localScale = new Vector3(1, 1, 1);
        }

        this.transform.Translate(new Vector3(playerMove, 0, 0));
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (col.CompareTag("firstdoor"))
            {
                this.transform.position = col.transform.GetChild(0).transform.position;
            }
            else if (col.CompareTag("seconddoor"))
            {
                this.transform.position = col.transform.parent.transform.position;
            }
        }
        if (col.CompareTag("class"))
        {
            classA = true;
            classB = false;
        }
        else if (col.CompareTag("class2"))
        {
            classB = true;
            classA = false;
        }
    }
}
