using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 movement;
    private Vector2 startPos;
    
    private float xMovement;
    public float speed;
    private bool jump;
    private bool outOfJumps;
    private int jumps = 3;
    void Start()
    {
        startPos = transform.position;
        rb = gameObject.GetComponent<Rigidbody2D>();
        jump = false;
        outOfJumps = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (outOfJumps == false && Input.GetKeyDown(KeyCode.W))
            jump = true;
        
        print(outOfJumps);
        
        xMovement = Input.GetAxis("Horizontal");

        if (transform.position.y <= -10)
        {
            transform.position = startPos;
        }
    }

    private void FixedUpdate()
    {
        // Physics
        if (jump == true )
        {
           outOfJumps = true;
           rb.AddForce(new Vector2(rb.velocity.x, 200));
           jump = false;
        }
        
        if(outOfJumps == false)
            rb.AddForce(new Vector2(xMovement*speed, rb.velocity.y));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Floor"){
            outOfJumps = false;
            print("Jump reset");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ramp"))
        {
            rb.AddForce(new Vector2(1000, rb.velocity.y));
        }

        if (other.CompareTag("Goodie"))
        {
            SidescrollerManager.scoreIncrease = true;
            Destroy(other.gameObject);
        }
    }
}
