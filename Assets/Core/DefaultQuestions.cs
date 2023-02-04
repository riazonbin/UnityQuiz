﻿using Assets.Core.Models;
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
        new Question{ Description = "Самая большая страна в мире?", Answer = "Россия"},
        new Question{ Description = "Крупнейший мировой материк?", Answer = "Евразия"},
        new Question{ Description = "Язык, на котором говорит больше всего людей в мире?", Answer = "Китайский"},
        new Question{Description = "Глава октябрьской революции?", Answer = "Ленин"},
        new Question{Description = "Кто доказал, что земля круглая?", Answer = "Аристотель"}
        };
    }
}
