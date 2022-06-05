using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    int speed = 6;

    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        //renderer = gameObject.GetComponentInChildren<SpriteRenderer>();
    }

    //[SerializeField][Range(1f, 10f)] float moveSpeed = 3f;

    // Update is called once per frame
    void Update()
    {

        float playerMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        Vector3 flipMove = Vector3.zero;

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            //playerMove = speed * Time.deltaTime;
            flipMove = Vector3.left;
            transform.localScale = new Vector3(-1, 1, 1);

        }

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            //playerMove = -speed * Time.deltaTime;
            flipMove = Vector3.right;
            transform.localScale = new Vector3(1, 1, 1);
        }

        transform.position += flipMove * speed * Time.deltaTime;
        //this.transform.Translate(new Vector3(playerMove, 0, 0));

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));

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
    }


}
