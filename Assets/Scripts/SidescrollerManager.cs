using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SidescrollerManager : MonoBehaviour
{
    private int score;
    public Text scoreText;
    public static bool scoreIncrease;

    private void Update()
    {
        if (scoreIncrease)
            ScoreIncrease();
    }

    void ScoreIncrease()
    {
        scoreIncrease = false;
        score++;
        scoreText.text = score.ToString();
    }
}
