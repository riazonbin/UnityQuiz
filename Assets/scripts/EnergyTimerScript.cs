using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyTimerScript : MonoBehaviour
{
    public const int energyTimer = 600;

    public float energyTimeRemaining;

    public Text timeEnergyText;

    public UserScript userScript;
    public DataScript dataScript;

    // Start is called before the first frame update
    void Start()
    {
        energyTimeRemaining = energyTimer;
        DisplayEnergyTimer();
    }

    // Update is called once per frame
    void Update()
    {
        EnergyTimerWork();

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


    public void RestartEnergyTimer()
    {
        userScript.currentUser.Energy += 1;
        userScript.currentUser.RefreshData();

        energyTimeRemaining = energyTimer;
        dataScript.RefreshDataAtDisplayAtGameplayScene();
    }
}
