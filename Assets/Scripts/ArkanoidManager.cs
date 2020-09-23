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
    private int score;
    public static bool scoreIncrease;
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
        if(scoreIncrease)
            ScoreIncrease();
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

    void ScoreIncrease()
    {
        scoreIncrease = false;
        score++;
        scoreText.text = score.ToString();
    }
}