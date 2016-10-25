using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roshambo
{
    class RockPlayer : Player
    {
        public RockPlayer(string name) : base(name)
        {
        }

        new Rosh generateRoshambo()
        {
            return Rosh.Rock;
        }
    }
}
