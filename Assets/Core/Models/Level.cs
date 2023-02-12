using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Core.Models
{
    public class Level
    {
        private int _currentLevel = 1;
        private int _currentExp = 0;
        private int growEdge = 15;
        private int currentLevelEdge = 90;
        public int CurrentLevel
        {
            get { return _currentLevel; }
            set
            {
                _currentLevel = value;
                LevelUpEvent?.Invoke();
                RefreshDataEvent?.Invoke();
                return;
            }
        }

        public int CurrentLevelEdge
        {
            get { return currentLevelEdge; }
            set
            {
                currentLevelEdge = value;
                return;
            }
        }

        public int CurrentExp
        {
            get { return _currentExp; }
            set
            {
                if (this.CurrentLevel > 1 && this.CurrentLevelEdge == 90)
                {
                    _currentExp = value;
                    CurrentLevelEdge += growEdge * CurrentLevel;

                    RefreshDataEvent?.Invoke();

                    return;
                }

                if (value >= currentLevelEdge)
                {
                    CurrentLevel++;
                    CurrentLevelEdge += growEdge * CurrentLevel;
                }
                _currentExp = value;

            }
        }

        public event LevelDelegate RefreshDataEvent;
        public event LevelDelegate LevelUpEvent;

        public delegate void LevelDelegate();
    }
}
