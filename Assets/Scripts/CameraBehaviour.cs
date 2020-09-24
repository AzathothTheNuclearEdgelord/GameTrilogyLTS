using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject player;
    private float yPos;
    private Transform playerLocation;
    void Start()
    {
        playerLocation = player.GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = new Vector3(playerLocation.position.x, playerLocation.position.y, -10);
        if (transform.position.x >= 25)
        {
            yPos = 3;
        }
    }
}
