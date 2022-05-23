using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingTrap : MonoBehaviour
{
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
            rb.isKinematic = false;
    }

    private void OnCollsionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {

        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
