using Assets.Core;
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
        game = new Game();
        game.GameOverEvent += GoToMainMenu;
        game.GameWin += GoToMainMenu;
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
