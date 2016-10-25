using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    class Player
    {
        public enum Rosh { Rock, Paper, Scissors };

        private int wins{ get; set; }
        private int losses{ get; set; }
        private int ties { get; set; }
        private string name { get; set; }

        public Player(string name)
        {
            this.name = name;
        }

        public Rosh generateRoshambo()
        {
            return Rosh.Paper;

        }
    }
}
