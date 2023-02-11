using Assets.Core;
using System;
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
    private Game game;
    // Start is called before the first frame update
    void Start()
    {

        game = gameCreation.game;
        FillChars();
    }

    public void FillChars()
    {
        ClearPanel();

        foreach (var letter in game.Keyboard.CharList)
        {
            var btn = Instantiate(preFab, panel);
            btn.GetComponent<Button>().onClick.AddListener(() => ChooseLetterButton(btn.GetComponent<Button>()));
            btn.GetComponentInChildren<Text>().text = letter.ToString();

        }
    }

    public void ClearPanel()
    {
        foreach (Button child in panel.GetComponentsInChildren<Button>())
        {
            Destroy(child.gameObject);
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
                sender.transform.Translate(1000, 0, 0);
                return;
            }
        }
    }
}
