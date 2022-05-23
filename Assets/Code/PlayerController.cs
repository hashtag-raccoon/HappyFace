using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllwe : MonoBehaviour
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
}
