using System;

namespace Roshambo
{
    abstract class Player
    {
        public enum Rosh { Rock, Paper, Scissors };

        private int wins;
        private int losses;
        private int ties;
        private string name;

        public int Wins
        {
            get
            {
                return wins;
            }

            set
            {
                wins = value;
            }
        }

        public int Losses
        {
            get
            {
                return losses;
            }

            set
            {
                losses = value;
            }
        }

        public int Ties
        {
            get
            {
                return ties;
            }

            set
            {
                ties = value;
            }
        }

        public Player(string name)
        {
            this.name = name;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }

        public abstract Rosh generateRoshambo();
    }
}
