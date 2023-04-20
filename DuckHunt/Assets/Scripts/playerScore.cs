using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class playerScore : MonoBehaviour
{
    public int currentScore = 0;
    public int maxScore;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI maxScoreText;

    public const string MAX_SCORE_KEY = "Max Score";
    private void Awake()
    {
        maxScore = PlayerPrefs.GetInt(MAX_SCORE_KEY);
        maxScoreText.text = maxScore.ToString();
    }

    public void CheckForMaxScore()
    {
        if (currentScore > maxScore)
        {
            PlayerPrefs.SetInt(MAX_SCORE_KEY, currentScore);
        }
    }

    public void Score()
    {
        currentScore++;
        scoreText.text = currentScore.ToString();
    }
}
