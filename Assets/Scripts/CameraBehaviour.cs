using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject player;
    private Transform playerLocation;
    void Start()
    {
        playerLocation = player.GetComponent<Transform>();
    }

    void Update()
    {
        transform.position = new Vector3(playerLocation.position.x, playerLocation.position.y, -10);
    }
}
