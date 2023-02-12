using Assets.Core;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Collections.Generic;
using System;
using UnityEditor.Animations;

public class QuestionScript : MonoBehaviour
{
    public GameObject preFab;
    public Transform panel;
    public GameObject text;
    public Transform keyboardPanel;
    private Game game;

    public Animator animator;

    public GameCreation gameCreation;
    public CreateKeyboard createKeyboard;

    public Stack<Button> QuestionsStack { get; set; } = new Stack<Button>();

    // Start is called before the first frame update
    void Start()
    {
        game = gameCreation.game;
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
        if(animator.GetBool("IsCorrectAnswer"))
        {
            return;
        }

        if (panel.GetComponentsInChildren<Button>().All(x => x.GetComponentInChildren<Text>().text != ""))
        {
            CheckAnswer();
        }
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

            //game.NextQuestion();

            //FillEmptyButtonsForWordGuess();
            //createKeyboard.FillChars();
        }
    }
}
