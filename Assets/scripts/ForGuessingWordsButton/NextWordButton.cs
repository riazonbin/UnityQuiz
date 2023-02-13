using Assets.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextWordButton : MonoBehaviour
{
    public Animator animator;
    public GameCreation gameCreation;

    public CreateKeyboard createKeyboard;
    public QuestionScript questionScript;
    public TimerScript timerScript;

    private Game game;
    // Start is called before the first frame update
    void Start()
    {
        game = gameCreation.game;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        animator.SetBool("IsCorrectAnswer", false);
        animator.SetBool("IsWrongAnswer", false);

        game.NextQuestion();
        createKeyboard.FillChars();
        questionScript.FillEmptyButtonsForWordGuess();
        questionScript.UnlockPanel();
        timerScript.RestartTimer();


        animator.SetBool("IsTouchedNextWordBtn", true);
    }
}
