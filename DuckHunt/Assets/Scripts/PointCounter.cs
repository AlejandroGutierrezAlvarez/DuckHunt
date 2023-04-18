using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointCounter : MonoBehaviour
{
    public TextMeshProUGUI pointText;

    public int numberOfPoints;

    private void Start()
    {
        pointText.text = 0.ToString();
    }

    public void GetPoints(int pointValue)
    {
        numberOfPoints += pointValue;
        pointText.text = numberOfPoints.ToString();
    }
}