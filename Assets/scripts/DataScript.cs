using Assets.Core;
using Assets.Core.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DataScript : MonoBehaviour
{
    public UserScript userScript;
    public GameCreation gameCreation;
    public Transform header;

    public Text LevelText;
    public Text LevelExpText;
    public Text EnergyText;
    public Text CoinsText;

    Game game;
    User user;

    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "GameplayScene")
        {
            game = gameCreation.game;
        }
        user = userScript.currentUser;

        RefreshDataAtDisplayAtGameplayScene();
    }

    public void RefreshDataAtDisplayAtGameplayScene()
    {
        LevelText.text = user.Level.CurrentLevel.ToString();
        LevelExpText.text = $"{user.Level.CurrentExp} / {user.Level.CurrentLevelEdge}";
        EnergyText.text = $"{user.Energy} / {user.MaxEnergy}"; ;
        CoinsText.text = user.Coins.ToString();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
