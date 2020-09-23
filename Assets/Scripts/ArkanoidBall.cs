using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkanoidBall : MonoBehaviour
{
    private Vector2 startPos;
    private float speedX = 3;
    private float speedY = 5;
    private bool isActive = false;

    private void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            isActive = true;
        }
        
        if (isActive)
            Movement();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.tag)
        {
            case "Brick":
                speedY = -speedY;
                break;
            case "Wall":
                speedX = -speedX;
                break;
            case "Paddle":
                speedY = -speedY;
                break;
        }
    }

    void DeathTrigger()
    {
        if (transform.position.y <= -5)
        {
            GameManager.LoadScene("Arkanoid");
        }
    }

    void Movement()
    {
            transform.Translate(speedX * Time.deltaTime, speedY * Time.deltaTime, 0);
            //DeathTrigger();
    }
}
