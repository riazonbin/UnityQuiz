using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneInteractionScene : MonoBehaviour
{
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
        SceneManager.LoadScene("GameplayScene");
    }
}
