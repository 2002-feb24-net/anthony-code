/*
Author: Anthony Harrington
Date: 3/3/2020
Program: Rock/Paper/Scissors Game
*/

using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            RockPaperScissorsGame game = new RockPaperScissorsGame();

            bool readyToQuit = false;
            while(!readyToQuit)
            {
                System.Console.WriteLine("Do you want to play a game (y or n)");
                string input = Console.ReadLine();
                if(input == "n")
                {
                    readyToQuit = true;
                }
                else
                {
                    Console. Clear();
                    game.PlayRound(); //plays a round of the game
                }
            }
            game.PrintRoundSummary(); //prints game summary of wins and losses
        }
    }
}