using Assets.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Core.Defaults
{
    public static class DefaultUser
    {
        public static User defaultUser = new User
        {
            Coins = 150,
            Level = new Level(),
            MaxEnergy = 30,
            Energy = 30,
            Name = "Новичок"
        };
    }
}
