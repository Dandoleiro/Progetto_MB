﻿using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static int score, highscore;
    public Text scoreText, highscoreText;

    private void Start()
    {
        Load();
    }

    private void Update()
    {
        scoreText.text = score.ToString();
        highscoreText.text = highscore.ToString();

        if (score > highscore)
        {
            highscore = score;
            Save();
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        Save();
    }
    public void SubtractScore(int amount)
    {
        score -= amount;
        Save();
    }

    public void Save()
    {
        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.SetInt("highscore", highscore);
    }
    public void Load()
    {
        score = PlayerPrefs.GetInt("score");
        highscore = PlayerPrefs.GetInt("highscore");
    }
}
