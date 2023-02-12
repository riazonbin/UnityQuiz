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

        public Level Level { get; set; }
        public int Experience { get; set; }

        public int Energy { get; set; }

        public int Coins { get; set; }

    }
}
