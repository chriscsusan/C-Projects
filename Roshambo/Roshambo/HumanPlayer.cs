using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    class HumanPlayer : Player
    {
        private Rosh result;
        private string name;
        private string temp;

        public HumanPlayer(string name) : base(name)
        {
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public override Rosh generateRoshambo()
        {
            while (true)
            {
                Console.Write("Choose Rock, Paper, or Scissors. (R/P/S)");
                temp = Console.ReadLine();
                switch (temp)
                {
                    case "S":
                        result = Rosh.Scissors;
                        break;
                    case "R":
                        result = Rosh.Rock;
                        break;
                    case "P":
                        result = Rosh.Paper;
                        break;
                    default:
                        Console.WriteLine("Please enter just the letter R, P, or S.");
                        continue;
                }
                break;
                
            }
            return result;
        }
    }
}
