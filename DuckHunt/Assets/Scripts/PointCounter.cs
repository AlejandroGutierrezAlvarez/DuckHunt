using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointCounter : MonoBehaviour
{
    public TextMeshProUGUI pointText;
    public TextMeshProUGUI maxPointText;

    public int numberOfPoints;
    public int maxPoints;

    public const string MAX_SCORE_KEY = "Max Score";

    public static  PointCounter Instance;

    private void Awake()
    {
        maxPoints = PlayerPrefs.GetInt(MAX_SCORE_KEY);
        maxPointText.text = maxPoints.ToString();
    }
    private void Start()
    {
        Instance = this;
        pointText.text = 0.ToString();
    }

    private void Update()
    {
        CheckForMaxScore();
    }

    public void GetPoints1p()
    {
        numberOfPoints += 1;
        pointText.text = numberOfPoints.ToString();
    }

    public void GetPoints3p()
    {
        numberOfPoints += 3;
        pointText.text = numberOfPoints.ToString();
    }
    public void CheckForMaxScore()
    {
        if (numberOfPoints > maxPoints)
        {
            PlayerPrefs.SetInt(MAX_SCORE_KEY, numberOfPoints);
        }
    }

}