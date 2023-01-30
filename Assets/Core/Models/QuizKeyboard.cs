using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizCore.Models
{
    public class QuizKeyboard
    {
        const int charCount = 40;
        private List<char> charList = new List<char>();

        public QuizKeyboard(string questionAnswer)
        {
            foreach(char c in questionAnswer.ToUpper())
            {
                CharList.Add(c);
            }

            Random random = new Random();
            for(int i = CharList.Count; i < CharCount; i++)
            {
                CharList.Add((char)random.Next('А', 'Я' + 1));
            }
            CharList.ShuffleList();
        }

        public static int CharCount => charCount;

        public List<char> CharList { get => charList; set => charList = value; }
    }
}
