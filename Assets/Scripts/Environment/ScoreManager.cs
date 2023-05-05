using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    //public Text scoreText;
    public TextMeshProUGUI scoreText;


    public void AddScore()
    {
        score++;
        UpdateScoreText();
        //score += 1;
        //Debug.Log("Score: " + score); // You can replace this with your own scoring system or UI update logic
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}

