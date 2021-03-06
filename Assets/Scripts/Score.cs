﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int initialScore = 0;
    Text scoreDisplay;
    float Timer;

    void Start()
    {
        scoreDisplay = GetComponent<Text>();
        scoreDisplay.text = initialScore.ToString();
        Timer = 1;
    }

    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            AddToScore();
            Timer = 1;
        }
        scoreDisplay.text = GetScore().ToString();
    }

    public void AddToScore()
    {
        initialScore += 1;
        PlayerPrefs.SetInt("Score", initialScore);
    }

    int GetScore()
    {
        return initialScore;
    }
}
