using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkanoidBall : MonoBehaviour
{
    private float speedX = 5;
    private float speedY = 5;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Translate(speedX * Time.deltaTime, speedY * Time.deltaTime, 0);
        DeathTrigger();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Brick")
        {
            speedY = -speedY;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Wall")
        {
            speedX = -speedX;
        }
    }

    void DeathTrigger()
    {
        if(transform.position.y <= -5)
            Application.Quit();
    }
}
