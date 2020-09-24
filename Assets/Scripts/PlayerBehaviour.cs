using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 movement;
    private Vector2 startPos;

    private AudioSource audioData;
    
    private float xMovement;
    public float speed;
    private bool jump;
    private bool canJump;

    public AudioSource goodiePickup;
    void Start()
    {
        startPos = transform.position;
        rb = gameObject.GetComponent<Rigidbody2D>();
        jump = false;
        canJump = false;
    }

    void Update()
    {
        if (canJump && Input.GetKeyDown(KeyCode.W))
            jump = true;
        
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
           rb.AddForce(new Vector2(rb.velocity.x, 400));
           jump = false;
        }
        
        if(canJump == false)
            rb.AddForce(new Vector2(xMovement, rb.velocity.y));
        else
            rb.AddForce(new Vector2(xMovement*speed, rb.velocity.y));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor")){
            canJump = true;
            print("Jump reset");
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
            canJump = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ramp"))
        {
            rb.AddForce(new Vector2(1000, rb.velocity.y));
        }

        if (other.CompareTag("Goodie"))
        {
            goodiePickup.Play();
            SidescrollerManager.scoreIncrease = true;
            Destroy(other.gameObject);
        }
    }
}
