using Assets.Core;
using Assets.Core.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCreation : MonoBehaviour
{
    public Game game;
    // Start is called before the first frame update
    void Awake()
    {
        game = new Game(Enum.TryParse(PlayerPrefs.GetString("gameMode"), true, out GameTypesEnum gameMode) 
            ? gameMode : default)
        {
            GameType = gameMode
        };
        game.GameOverEvent += GoToMainMenu;
        game.GameWin += GoToMainMenu;
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GoToMainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
