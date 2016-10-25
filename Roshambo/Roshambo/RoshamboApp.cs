using Roshambo;
using System;
using static Roshambo.Player;

namespace RoshamboApp
{
    class Program
    {
        static void Main(string[] args)
        {

        Player opponent;
		string opponentChoice;
		Rosh humanResult;
		Rosh opponentResult;
		String playAgain = "y";

		Console.WriteLine("Get ready to play Roshambo.");
        Console.WriteLine("What is your name?");
		Player humanPlayer = new HumanPlayer(Console.ReadLine());
		while (playAgain.Equals("y")) {
			while (true) {
                    Console.WriteLine("Do you want to play against a predictable opponent? (y/n)");
				opponentChoice = Console.ReadLine();
				if (opponentChoice.Equals("y")) {
					opponent = new RockPlayer("Dwayne Johnson");
					break;
				} else if (opponentChoice.Equals("n")) {
					opponent = new RandomPlayer("Loose cannon");
					break;
				} else {
                    Console.WriteLine("Please choose Y for yes or N for no.");
					continue;
				}
			}
			
			humanResult = humanPlayer.generateRoshambo();
			opponentResult = opponent.generateRoshambo();
            Console.WriteLine(humanPlayer.getName() + " threw: " + humanResult);
            Console.WriteLine(opponent.getName() + " threw: " + opponentResult);

			switch (humanResult) {
			case Rosh.Rock:
				if (opponentResult == Rosh.Paper) {
                            Console.WriteLine("Dang, you lost.");
					humanPlayer.Losses++;
				} else if (opponentResult == Rosh.Rock) {
                            Console.WriteLine("It's a tie!  Nobody wins.");
					humanPlayer.Ties++;
				} else {
                            Console.WriteLine("You won!  Woo!");
					humanPlayer.Wins++;
				}
				break;
			case Rosh.Paper:
				if (opponentResult == Rosh.Scissors) {
					Console.WriteLine("Uh oh, you lost.");
					humanPlayer.Losses++;
				} else if (opponentResult == Rosh.Paper) {
                            Console.WriteLine("It's a tie!  Nobody wins.");
					humanPlayer.Ties++;
				} else {
                            Console.WriteLine("You won!  Woo!");
					humanPlayer.Wins++;
				}
				break;
			case Rosh.Scissors:
				if (opponentResult == Rosh.Rock) {
                            Console.WriteLine("You lost.  Better luck next time.");
					humanPlayer.Losses++;
				} else if (opponentResult == Rosh.Scissors) {
                            Console.WriteLine("It's a tie!  Nobody wins.");
					humanPlayer.Ties++;
				} else {
                            Console.WriteLine("You won!  Woo!");
					humanPlayer.Wins++;
				}
				break;
			default:
                break;
			}
                Console.WriteLine(
					"\nWins: " + humanPlayer.Wins + "\nLosses: " + humanPlayer.Losses + "\nTies: " + humanPlayer.Ties
							+ "\nTotal games: " + (humanPlayer.Wins + humanPlayer.Losses + humanPlayer.Ties));
			Console.ReadLine();
                Console.WriteLine("\nWould you like to play again? (y/n)");
			playAgain = Console.ReadLine();
		}
            Console.WriteLine("Goodbye.");
	}
        }
    }

