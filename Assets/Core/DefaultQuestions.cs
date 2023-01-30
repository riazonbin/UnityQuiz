using Assets.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Core
{
    public static class DefaultQuestions
    {
        public static List<Question> Questions = new()
        {
        new Question{ Description = "Кто поцарапал Сережу?", Answer = "Кот"},
        new Question{ Description = "Кто купил сайфуллина?", Answer = "Шарипов"},
        new Question{Description = "Глава октябрьской революции?", Answer = "Ленин"},
        new Question{Description = "Кто доказал, что земля круглая?", Answer = "Аристотель"}
        };
    }
}
