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
        public static List<Question> RandomQuestions = new()
        {
            new Question{ Description = "Староста 320й группы?", Answer = "Рома"},
            new Question{ Description = "Самая большая страна в мире?", Answer = "Россия"},
            new Question{ Description = "Крупнейший мировой материк?", Answer = "Евразия"},
            new Question{ Description = "Язык, на котором говорит больше всего людей в мире?", Answer = "Китайский"},
            new Question{Description = "Глава октябрьской революции?", Answer = "Ленин"},
            new Question{Description = "Кто доказал, что земля круглая?", Answer = "Аристотель"},
            new Question{Description = "Самое популярное выражение в мире?", Answer = "ОК"},
            new Question{Description = "Фамилия создателя конвейера?", Answer = "Форд"}
        };

        public static List<Question> ScienceQuestions = new()
        {
            new Question{ Description = "Какая самая маленькая частица вещества?", Answer = "Атом" },
            new Question{ Description = "Наука, изучающая живые существа?", Answer = "Биология" },
            new Question{ Description = "Как называется процесс, при котором растения производят свою собственную пищу?", Answer = "Фотосинтез" },
            new Question{ Description = "Что изучает вселенную?", Answer = "Астрономия" },
            new Question{ Description = "Что изучает вещество и энергию?", Answer = "Физика" },
            new Question{ Description = "Кто открыл закон гравитации?", Answer = "Ньютон" },
            new Question{ Description = "Что изучает Землю и ее процессы?", Answer = "Геология" },
            new Question{ Description = "Кто сформулировал теорию эволюции путем естественного отбора?", Answer = "Дарвин" }
        };

        public static List<Question> HistoryQuestions = new()
        {
            new Question{ Description = "Кто стал первым императором Рима?", Answer = "Октавиан" },
            new Question{ Description = "Как назывался царь Иудеи, судимый Иисусом Христом?", Answer = "Ирод" },
            new Question{ Description = "Где произошла Баталия при Гаундике?", Answer = "Гаундика" },
            new Question{ Description = "Кто стал первым императором Франции?", Answer = "Наполеон" },
            new Question{ Description = "Как назывался вождь восстания против римской оккупации в Иудее в 66 г. до н.э.", Answer = "Эвтус" },
            new Question{ Description = "Как называлась великая княжна России, защитница Отечества во время Патриотической войны?", Answer = "Екатерина" },
            new Question{ Description = "Имя вождь восстания против турецкой оккупации в Болгарии в 1876 году?", Answer = "Васил" },
            new Question{ Description = "Как назывался первый царь России?", Answer = "Иван" },
            new Question{ Description = "Кто выиграл Битву при Агранде?", Answer = "Александр" },
            new Question{ Description = "Имя вождя восстания против польской оккупации в Украине в 1648 году?", Answer = "Богдан" }
        };

        public static List<Question> ArtQuestions = new()
        {
            new Question{ Description = "Какой художник написал картину 'Мона Лиза'?", Answer = "Леонардо" },
            new Question{ Description = "Кто написал оперу 'Травиата'?", Answer = "Верди" },
            new Question{ Description = "Какое искусство представлено в шедевре 'Венера и Марс'?", Answer = "Живопись" },
            new Question{ Description = "Кто является автором пьесы 'Отелло'?", Answer = "Шекспир" },
            new Question{ Description = "Какой архитектурный стиль представлен в Венском оперном театре?", Answer = "Барокко" },
            new Question{ Description = "Как называется художественный направление, в котором используется только черно-белые тона?", Answer = "Графика" },
            new Question{ Description = "Кто из художников создал серию картин 'Времена года'?", Answer = "Писарев" },
            new Question{ Description = "Какой художественный направление отмечается характерными яркими цветами и объемными формами?", Answer = "Импрессионизм" }
        };

        public static List<Question> WorldQuestions = new()
        {
            new Question{ Description = "Какое животное является символом Африки?", Answer = "Лев"},
            new Question{ Description = "Как называется птица, считающаяся символом США?", Answer = "Орел"},
            new Question{ Description = "Как называется хищник, обитающий в тропических лесах Южной Америки?", Answer = "Ягуар"},
            new Question{ Description = "Как называется кошка, обитающая в джунглях Южной Америки?", Answer = "Онсам"},
            new Question{ Description = "Как называется млекопитающее, являющееся символом Австралии?", Answer = "Кенгуру"}
        };

        public static List<Question> CinemaQuestions = new()
        {
            new Question{ Description = "Какой фильм стал самым прибыльным в истории кинематографа?", Answer = "Аватар" },
            new Question{ Description = "Какое известное киностудия была основана в 1923 году Уолтом Диснеем?", Answer = "Дисней" }
        };

        public static List<Question> SportQuestions = new()
        {
            new Question{ Description = "В какой игре необходимо выбить как можно больше количество фигур битой?", Answer = "Городки" },
            new Question{ Description = "Как называется игра, в которой две команды по 7 игроков стараются забросить мяч в ворота другой команды?", Answer = "Гандбол" },
            new Question{ Description = "Что стремится установить спортсмен в своей дисциплине?", Answer = "Рекорд" },
            new Question{ Description = "Что является началом пути к финишу в спортивных соревнованиях?", Answer = "Старт" },
            new Question{ Description = "Сколько игроков принимает участие в регби?", Answer = "15 игроков в каждой команде" },
            new Question{ Description = "Как называются гонки на мотоциклах по мотодрому?", Answer = "Спидвей" }
        };

        public static List<Question> EndPhraseQuestions = new()
        {
            new Question{ Description = "Зимой и летом - одним...?", Answer = "Цветом" },
            new Question{ Description = "Мы считали дырки в сыре три плюс два равно...?", Answer = "Пять" },
            new Question{ Description = "Мама сшила мне штаны из березовой коры, чтобы тело не потело, не кусали...?", Answer = "Комары" },
        };
    }
}
