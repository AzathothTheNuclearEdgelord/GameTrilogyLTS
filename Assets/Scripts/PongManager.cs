using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PongManager : MonoBehaviour
{
    int leftScore;
    int rightScore;

    public Text rightText;
    public Text leftText;
    public static bool leftScoreIncrease;
    public static bool rightScoreIncrease;

    public GameObject Ball;

    private void Start()
    {
        Ball = GameObject.Find("BallBase");
    }

    private void Update()
    {
        /*
        print(leftScore);
        print(rightScore);
        */
        rightText.text = rightScore.ToString();
        leftText.text = leftScore.ToString();

        if (leftScoreIncrease == true)
            LeftScoreIncrease();
        if (rightScoreIncrease == true)
            RightScoreIncrease();
    }

    private void LeftScoreIncrease()
    {
        leftScore++;
        leftText.text = leftScore.ToString();
        leftScoreIncrease = false;
    }

    private void RightScoreIncrease()
    {
        rightScore++;
        rightText.text = rightScore.ToString();
        rightScoreIncrease = false;
    }
}
