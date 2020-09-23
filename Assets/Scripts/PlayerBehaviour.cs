using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    private float xMovement;
    private Vector2 movement;
    public float speed;
    private bool jump;
    private bool jumped;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        jump = false;
        jumped = false;
    }

    // Update is called once per frame
    void Update()
    {
        print(jumped);
        if (jumped == false && Input.GetAxis("Jump") > 0)
        {
            jump = true;
        }
        
        xMovement = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        // Physics
        if (jump == true )
        {
           jumped = true;
           rb.AddForce(new Vector2(rb.velocity.x, 200));
           jump = false;
        }
        
        rb.AddForce(new Vector2(xMovement*10, rb.velocity.y));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Floor"){
            jumped = false;
            print("Jump reset");
        }
    }
}
