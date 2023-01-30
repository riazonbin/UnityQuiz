using Assets.Core;
using UnityEngine;
using UnityEngine.UI;

public class QuestionScript : MonoBehaviour
{
    public GameObject preFab;
    public Transform panel;
    public GameObject text;

    // Start is called before the first frame update
    void Start()
    {
        Game game = GameObject.Find("ScriptHolder").GetComponent<GameCreation>().game;

        //var question = game[Random.Range(0, Answers.Count - 1)];
        text.GetComponent<Text>().text = game.currentQuestion.Description;

        for (int i = 0; i < game.currentQuestion.Answer.Length; i++)
        {
            var btn = Instantiate(preFab, panel);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
