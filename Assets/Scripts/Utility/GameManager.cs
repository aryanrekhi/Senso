using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject winImage;
    public TextMeshProUGUI timeText;
    public int totalEnemyCount;
    public ScoreManager scoreManager;

    private int enemiesKilled = 0;
    private bool isGameEnded = false;
    private float startTime;

    private void Start()
    {
        startTime = Time.time;
    }

    public void EnemyKilled()
    {
        enemiesKilled++;

        if (enemiesKilled >= totalEnemyCount && !isGameEnded)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        isGameEnded = true;
        winImage.SetActive(true);

        float elapsedTime = Time.time - startTime;
        timeText.text = "Time: " + FormatTime(elapsedTime);
    }

    private string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);

        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
