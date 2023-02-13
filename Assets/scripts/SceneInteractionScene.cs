using Assets.Core.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneInteractionScene : MonoBehaviour
{
    public GameTypesEnum gameType = GameTypesEnum.Random;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GoToRewardsScene()
    {
        SceneManager.LoadScene("RewardsScene");
    }

    void GoToMenuScene()
    {
        SceneManager.LoadScene("MenuScene");
    }

    void GoToGameplayScene()
    {
        PlayerPrefs.SetString("gameMode", gameType.ToString());
        SceneManager.LoadScene("GameplayScene");

    }
}
