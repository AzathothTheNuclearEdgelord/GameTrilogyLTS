using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private float speedX = 5;
    private float speedY = 5;

    void Update()
    {
        transform.Translate(speedX * Time.deltaTime, speedY * Time.deltaTime, 0);
        DeathTrigger();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        switch (other.gameObject.tag)
        {
            case "Wall":
                speedY = -speedY;
                speedX *= 1.02f;
                speedY *= 1.02f;
                break;
            case "Paddle":
                speedX = -speedX;
                break;
        }
    }

    private void DeathTrigger()
    {
        if (transform.position.x >= 9)
        {
            PongManager.rightScoreIncrease = true;
            PositionReset();
        }

        if (transform.position.x <= -9)
        {
            PongManager.leftScoreIncrease = true;
            PositionReset();
        }
    }

    private void PositionReset()
    {
        if (speedX < 0)
            speedX = -5;
        else
            speedX = 5;

        if (speedY < 0)
            speedY = -5;
        else
            speedY = 5;
        
        transform.position = new Vector3(0, 0, 0);
    }
}
