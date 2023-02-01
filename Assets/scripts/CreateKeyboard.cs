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
    public Transform questionPanel;
    // Start is called before the first frame update
    void Start()
    {
        Game game = gameCreation.game;

        foreach(var letter in game.Keyboard.CharList)
        {
            var btn = Instantiate(preFab, panel);
            btn.GetComponent<Button>().onClick.AddListener(() => ChooseLetterButton(btn.GetComponent<Button>()));
            btn.GetComponentInChildren<Text>().text = letter.ToString();
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChooseLetterButton(Button sender)
    {
        foreach (Button child in questionPanel.GetComponentsInChildren<Button>())
        {
            if (child.GetComponentInChildren<Text>().text == "")
            {
                child.GetComponentInChildren<Text>().text = sender.GetComponentInChildren<Text>().text;
                sender.interactable = (false);
                return;
            }
        }
    }
}
