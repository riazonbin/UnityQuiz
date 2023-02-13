using Assets.Core;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Collections.Generic;
using System;
using UnityEditor.Animations;
using Assets.Core.Models;
using Assets;

public class QuestionScript : MonoBehaviour
{
    public GameObject preFab;
    public Transform panel;
    public GameObject text;
    public Transform keyboardPanel;
    private Game game;
    private User currentUser;

    public Animator animator;

    public GameCreation gameCreation;
    public CreateKeyboard createKeyboard;
    public UserScript userScript;
    public DataScript dataScript;

    public Stack<Button> QuestionsStack { get; set; } = new Stack<Button>();

    // Start is called before the first frame update
    void Start()
    {
        game = gameCreation.game;
        currentUser = userScript.currentUser;
        FillEmptyButtonsForWordGuess();
    }

    public void FillEmptyButtonsForWordGuess()
    {
        ClearPanelForGuess();


        //var question = game[Random.Range(0, Answers.Count - 1)];
        text.GetComponent<Text>().text = game.currentQuestion.Description;

        for (int i = 0; i < game.currentQuestion.Answer.Length; i++)
        {
            var btn = Instantiate(preFab, panel);
            btn.GetComponent<Button>().onClick.AddListener(() => ReturnButton(btn.GetComponent<Button>()));
        }
    }

    public void ClearPanelForGuess()
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

    public void ReturnButton(Button sender)
    {
        try
        {
            Button btn = keyboardPanel.GetComponentsInChildren<Button>()
                .Where(x => x.interactable == false && x.GetComponentInChildren<Text>().text == sender.GetComponentInChildren<Text>().text).FirstOrDefault();

            sender.GetComponentInChildren<Text>().text = "";
            btn.transform.Translate(-1000, 0, 0);
            btn.interactable = true;
        }
        catch { }
    }

    public void CheckAnswer()
    {
        string answer = "";

        foreach (Button child in panel.GetComponentsInChildren<Button>())
        {
            answer += child.GetComponentInChildren<Text>().text;
        }

        if (game.CheckWord(answer))
        {
            animator.SetBool("IsCorrectAnswer", true);
            currentUser.Energy -= 1;
            currentUser.Level.CurrentExp += 10;

            //game.NextQuestion();

            //FillEmptyButtonsForWordGuess();
            //createKeyboard.FillChars();
        }
        else
        {
            currentUser.Energy -= 2;
            animator.SetBool("IsWrongAnswer", true);
        }

        BlockPanel();
        currentUser.RefreshData();
        dataScript.RefreshDataAtDisplayAtGameplayScene();
    }

    public void BlockPanel()
    {
        foreach(Button button in panel.GetComponentsInChildren<Button>())
        {
            button.interactable = false;
        }
    }

    public void UnlockPanel()
    {
        foreach (Button button in panel.GetComponentsInChildren<Button>())
        {
            button.interactable = true;
        }
    }
}
