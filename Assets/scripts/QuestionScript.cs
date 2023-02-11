using Assets.Core;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Collections.Generic;

public class QuestionScript : MonoBehaviour
{
    public GameObject preFab;
    public Transform panel;
    public GameObject text;
    public GameCreation gameCreation;
    public Transform keyboardPanel;
    public Game game;
    public Stack<Button> QuestionsStack { get; set; } = new Stack<Button>();

    // Start is called before the first frame update
    void Start()
    {
        game = gameCreation.game;

        //var question = game[Random.Range(0, Answers.Count - 1)];
        text.GetComponent<Text>().text = game.currentQuestion.Description;

        for (int i = 0; i < game.currentQuestion.Answer.Length; i++)
        {
            var btn = Instantiate(preFab, panel);
            btn.GetComponent<Button>().onClick.AddListener(() => ReturnButton(btn.GetComponent<Button>()));
        }
    }

    // Update is called once per frame
    void Update()
    {
        var test = game.currentQuestion;
        if (panel.GetComponentsInChildren<Button>().All(x => x.GetComponentInChildren<Text>().text != ""))
        {
            NextQuestion();
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

    public void NextQuestion()
    {
        string answer = "";

        foreach (Button child in panel.GetComponentsInChildren<Button>())
        {
            answer += child.GetComponentInChildren<Text>().text;
        }

        if (game.CheckWord(answer))
        {
            game.NextQuestion();
            text.GetComponent<Text>().text = game.currentQuestion.Description;

            foreach (Button child in panel.GetComponentsInChildren<Button>())
            {
                Destroy(child.gameObject);
            }

            for (int i = 0; i < game.currentQuestion.Answer.Length; i++)
            {
                var btn = Instantiate(preFab, panel);
                btn.GetComponent<Button>().onClick.AddListener(() => ReturnButton(btn.GetComponent<Button>()));
            }
        }
    }
}
