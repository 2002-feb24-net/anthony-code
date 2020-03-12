using System;

namespace RockPaperScissors.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Iinputoutput inputOUtputSpecific = new Iinputoutput();
            RockPaperScissorsGame game = new RockPaperScissorsGame();

            bool readyToQuit = false;
            while (!readyToQuit)
            {
                System.Console.WriteLine("Do you want to play a game (y or n)");
                string input = Console.ReadLine();
                if (input == "n")
                {
                    readyToQuit = true;
                }
                else
                {
                    Console.Clear();
                    game.PlayRound(); //plays a round of the game
                }
            }
            game.PrintRoundSummary(); //prints game summary of wins and losses
        }
    }
}
