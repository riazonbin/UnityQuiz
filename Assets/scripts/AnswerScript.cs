using QuizCore.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerScript : MonoBehaviour
{
    public GameObject preFab;
    public Transform panel;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        var question = Answers[Random.Range(0, Answers.Count - 1)];
        text.GetComponent<Text>().text = question.Description;

        for(int i = 0; i < question.Answer.Length; i++)
        {
            var btn = Instantiate(preFab, panel);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static List<Question> Answers = new()
    {
        new Question{ Description = "Кто поцарапал Сережу?", Answer = "Кот"},
        new Question{ Description = "Кто купил сайфуллина?", Answer = "Шарипов"}
    };
}
