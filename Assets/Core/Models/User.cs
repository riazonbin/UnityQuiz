using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Core.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Level Level { get; set; } = new Level();

        private int currentEnergy;

        public int MaxEnergy { get; set; }

        public int Energy 
        {
            get { return currentEnergy; }
            set
            {
                if(value > MaxEnergy)
                {
                    currentEnergy = MaxEnergy;
                    return;
                }
                currentEnergy = value;
            }
        }

        public int Coins { get; set; }

        public User()
        {
            Level.LevelUpEvent += LevelUp;
            Level.RefreshDataEvent += RefreshData;
        }

        public void RefreshData()
        {
            var connection = new MongoConnection();
            connection.RefreshUserData(this);
        }

        public void Subscribe()
        {
            Level.LevelUpEvent += LevelUp;
        }

        private void LevelUp()
        {
            MaxEnergy= MaxEnergy + 5;
            Energy = MaxEnergy;

            Coins += 30;
        }

    }
}
