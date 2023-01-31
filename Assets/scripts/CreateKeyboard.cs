using Assets.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateKeyboard : MonoBehaviour
{
    public GameObject preFab;
    public Transform panel;
    public GameCreation gameCreation;
    // Start is called before the first frame update
    void Start()
    {
        Game game = gameCreation.game;

        foreach(var letter in game.Keyboard.CharList)
        {
            var btn = Instantiate(preFab, panel);
            btn.GetComponentInChildren<Text>().text = letter.ToString();
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
