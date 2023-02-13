using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public const int maxTime = 90;

    public float questionTimeRemaining;

    private bool timerIsRunning = false;
    public Text timeText;

    public QuestionScript questionScript;

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
        questionTimeRemaining = maxTime;
        DisplayTime();
    }

    // Update is called once per frame
    void Update()
    {
        if (!timerIsRunning)
        {
            return;
        }

        TimerWork();
    }

    private void TimerWork()
    {
        if (questionScript.animator.GetBool("IsWrongAnswer") || questionScript.animator.GetBool("IsCorrectAnswer"))
        {
            timerIsRunning = false;
            return;
        }

        DisplayTime();

        if (questionTimeRemaining >= 0)
        {
            questionTimeRemaining -= Time.deltaTime;
        }
        else
        {
            questionTimeRemaining = 0;
            timerIsRunning = false;
            questionScript.CheckAnswer();
        }
    }

    private void DisplayTime()
    {
        var time = TimeSpan.FromSeconds(questionTimeRemaining);

        timeText.text = string.Format("{0:00}:{1:00}", time.Minutes, time.Seconds);
    }

    public void RestartTimer()
    {
        questionTimeRemaining = maxTime;
        timerIsRunning= true;
    }
}
