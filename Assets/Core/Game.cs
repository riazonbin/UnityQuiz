﻿using Assets.Core.Models;
using System;
using System.Collections.Generic;

namespace Assets.Core
{
    public class Game
    {
        public int PassedWords { get; set; }
#nullable enable
        public Question? currentQuestion { get; set; }
        public List<Question>? Questions { get; set; }
#nullable disable

        public const int DefaultPassedWords = 0;

        public bool IsWordPassed { get; set; } = false;


        public delegate void GameOverDelegate();
        public GameOverDelegate GameOver;
        public GameOverDelegate GameWin;
        public QuizKeyboard Keyboard { get; set; }

        public Game()
        {
            GetAllQuestions();
            //RestoreData();
            GetRandomQuestion();
            Keyboard = new QuizKeyboard(currentQuestion.Answer);
        }

        public void GetRandomQuestion()
        {
            Random random = new Random();
            if (Questions.Count == 0)
            {
                GameWin();
            }

            if (currentQuestion is not null)
            {
                Questions.Remove(currentQuestion);
            }
            currentQuestion = Questions[random.Next(Questions.Count)];
        }

        public void NextQuestion()
        {
            if (!IsWordPassed)
            {
                //ReduceEnergy();
            }
            GetRandomQuestion();
            Keyboard = new QuizKeyboard(currentQuestion.Answer);
        }

        public List<Question> GetAllQuestions()
        {
            //QuizCore.Database.MongoConnection connection = new QuizCore.Database.MongoConnection();
            //var collection = connection.GetAllQuestions();

            //return Questions = collection.ShuffleList();
            return Questions = DefaultQuestions.Questions.ShuffleList();
        }

        public bool CheckWord(string word)
        {
            if (currentQuestion.Answer.ToUpper() == word.ToUpper())
            {
                PassedWords++;
                IsWordPassed = true;
                return true;
            }
            //ReduceEnergy();
            IsWordPassed = false;
            return false;
        }

        //public bool ReduceEnergy()
        //{
        //    if (Health == 1)
        //    {
        //        //GameOver();
        //        return false;
        //    }
        //    Health--;
        //    return true;
        //}

        //public void RestoreData()
        //{
        //    Health = DefaultHealth;
        //    PassedWords = DefaultPassedWords;
        //}
    }
}