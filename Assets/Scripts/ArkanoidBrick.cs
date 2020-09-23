using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkanoidBrick : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            print("it hit");
            ArkanoidManager.scoreIncrease = true;
            Destroy(this.gameObject);
        }
    }
}
