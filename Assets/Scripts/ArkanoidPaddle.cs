using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkanoidPaddle : MonoBehaviour
{
    private float movement;
    public int speed;

    private void Update()
    {
        movement = Input.GetAxis("Horizontal");
        //transform.position = transform.position + new Vector3(movement, transform.position.y, 0) * Time.deltaTime * speed;
        transform.position += new Vector3(movement, 0, 0) * (Time.deltaTime * speed);
        LocationLimiter();
    }

    private void LocationLimiter()
    {
        if (transform.position.x <= -8)
            transform.position = new Vector3(-8, transform.position.y, transform.position.z);
        if (transform.position.x >= 8)
            transform.position = new Vector3(8, transform.position.y, transform.position.z);
    }
}
