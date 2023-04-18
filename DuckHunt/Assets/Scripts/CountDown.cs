using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountDown : MonoBehaviour
{
    public float countDownTime = 30;
    private float timeRemaining = 0;

    public TextMeshProUGUI countdownTex;

    private void Start()
    {
        timeRemaining = countDownTime;
        countdownTex.text = timeRemaining.ToString("0");
    }

    private void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            countdownTex.text = timeRemaining.ToString("0");
        }
        else
        {
            timeRemaining = 0;
            countdownTex.text = timeRemaining.ToString("0");
        }
    }
}