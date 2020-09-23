using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ArkanoidManager : MonoBehaviour
{
    public GameObject brick;
    private Vector2 spawnPos;
    void Start()
    {
        spawnPos = new Vector2(-8.25f, 4.5f);
        for (int i = 0; i < 5; i++)
        {
            SpawnRow();
            spawnPos = new Vector2(-8.25f, spawnPos.y -1 );
        }
    }
    // Delegated this to a different function probably because I am working somewhat inconsistently
    void SpawnRow()
    {
            for (int i = 0; i < 12; i++)
            {
                Instantiate(brick, spawnPos, Quaternion.identity);
                spawnPos.x += 1.5f;
            }
    }
}
