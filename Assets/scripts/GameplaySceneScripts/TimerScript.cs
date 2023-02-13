using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public const int maxTime = 90;
    public const int energyTimer = 10;

    public float questionTimeRemaining;
    public float energyTimeRemaining;

    private bool timerIsRunning = false;
    public Text timeText;
    public Text timeEnergyText;

    public QuestionScript questionScript;
    public UserScript userScript;
    public DataScript dataScript;

    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
        questionTimeRemaining = maxTime;
        energyTimeRemaining = energyTimer;
        DisplayTime();
    }

    // Update is called once per frame
    void Update()
    {
        EnergyTimerWork();

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


    private void EnergyTimerWork()
    {

        DisplayEnergyTimer();

        if (energyTimeRemaining >= 0)
        {
            energyTimeRemaining -= Time.deltaTime;
        }
        else
        {
            energyTimeRemaining = 0;
            RestartEnergyTimer();
        }
    }

    private void DisplayEnergyTimer()
    {
        var time = TimeSpan.FromSeconds(energyTimeRemaining);

        timeEnergyText.text = string.Format("{0:00}:{1:00}", time.Minutes, time.Seconds);
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

    public void RestartEnergyTimer()
    {
        userScript.currentUser.Energy += 1;
        energyTimeRemaining = energyTimer;
        dataScript.RefreshDataAtDisplayAtGameplayScene();
    }
}
