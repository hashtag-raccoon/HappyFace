using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllwe : MonoBehaviour
{
    //int speed = 6;

    //private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();

        ////renderer = gameObject.GetComponentInChildren<SpriteRenderer>();
    }

    //[SerializeField][Range(1f, 10f)] float moveSpeed = 3f;

    // Update is called once per frame
    void Update()
    {

        //float playerMove = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //Vector3 flipMove = Vector3.zero;

        ////if (Input.GetAxisRaw("Horizontal")<0)
        ////{
        ////    //playerMove = speed * Time.deltaTime;
        ////    flipMove = Vector3.left;
        ////    transform.localScale = new Vector3(-1, 1, 1);

        ////}

        ////if (Input.GetAxisRaw("Horizontal") > 0)
        ////{
        ////    //playerMove = -speed * Time.deltaTime;
        ////    flipMove = Vector3.right;
        ////    transform.localScale = new Vector3(1, 1, 1);
        ////}

        //transform.position += flipMove * speed * Time.deltaTime;
        ////this.transform.Translate(new Vector3(playerMove, 0, 0));

        //anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));



        //if (health == 0)
        //{
        //    if (!isDie)
        //        Die();

        //    return;
        //}
    }

    //void OnTriggerStay2D(Collider2D col)
    //{
    //    if (Input.GetKeyDown(KeyCode.Space))
    //    {
    //        if (col.CompareTag("firstdoor"))
    //        {
    //            this.transform.position = col.transform.GetChild(0).transform.position;
    //        }
    //        else if (col.CompareTag("seconddoor"))
    //        {
    //            this.transform.position = col.transform.parent.transform.position;
    //        }
    //    }
    //}

    //void Die()
    //{
    //    idDie = true;

    //    rigid.velocity = Vector2.zero;

    //    animator.Play("Die");

    //    BoxCollider2D[] colls = gameObject.GetComponents<BoxCollider2D>();
    //    colls[0].enalbled = false;
    //    colls[1].enalbled = false;

    //    Vector2 dieVelocity = new Vector2(0, 10f);
    //    rigid.AddForce(dieVelocity, ForceMode2D.Impulse);

    //    invoke("RestartStage", 2f);
    //}
    //public static void RestartStage ()
    //{
    //    Time.timeScale = 0f;

    //    SceneManager.LoadScene(stageLevel, LoadSceneMode.Single);
    //}


}
