using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public bool isLeft;
    private float movement;
    public int speed = 10;

    void Update()
    {
        LocationLimitor();
        DirectionSelector();
        transform.position += new Vector3(0, movement, 0) * (Time.deltaTime * speed);
    }

    void DirectionSelector()
    {
        if (isLeft == true)
        {
            movement = Input.GetAxis("VerticalLeft");
        }
        else
        {
            movement = Input.GetAxis("VerticalRight");
        }
    }

    void LocationLimitor()
    {
        if (transform.position.y > 4)
        {
           transform.position = new Vector3(transform.position.x, 4, 0); 
        }
        
        if (transform.position.y < -4)
        {
           transform.position = new Vector3(transform.position.x, -4, 0); 
        }
    }
}
