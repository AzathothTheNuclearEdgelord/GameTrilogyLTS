using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ArkanoidManager : MonoBehaviour
{
    public GameObject brick;
    private Vector2 spawnPos;
    private static int score;
    public Text scoreText;
    void Start()
    {
        spawnPos = new Vector2(-8.25f, 4.5f);
        for (int i = 0; i < 5; i++)
        {
            SpawnRow();
            spawnPos = new Vector2(-8.25f, spawnPos.y -1 );
        }
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }

    // Delegated this to a different function because I am probably working somewhat inconsistently
    void SpawnRow()
    {
        for (int i = 0; i < 12; i++)
        {
            Instantiate(brick, spawnPos, Quaternion.identity);
            spawnPos.x += 1.5f;
        }
    }

    public static void ScoreIncrease()
    {
        score++;
    }
}