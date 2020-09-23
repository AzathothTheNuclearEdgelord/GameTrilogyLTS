using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkanoidBrick : MonoBehaviour
{
    public GameObject arkanoidManager;

    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            ArkanoidManager.ScoreIncrease();
            Destroy(this.gameObject);
        }
    }
}
