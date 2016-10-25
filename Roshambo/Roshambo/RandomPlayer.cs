using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    class RandomPlayer : Player
    {
        public RandomPlayer(string name) : base(name)
        {
        }

        public new Rosh generateRoshambo()
        {
            Rosh choice = Rosh.Paper;
            Random rand = new Random();
            int result = rand.Next(1,3);
            switch (result)
            {
                case 1:
                    choice = Rosh.Rock;
                    break;
                case 2:
                    choice = Rosh.Paper;
                    break;
                case 3:
                    choice = Rosh.Scissors;
                    break;
            }
            return choice;
        }
    }
}
