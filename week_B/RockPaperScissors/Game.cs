using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    public class RockPaperScissorsGame
    {
        int wins = 0;
        int loss = 0;
        int ties = 0;

        List<string> roundResults = new List<string>();
        int [] score = new int[3];

        // gets the users selected answer
        public int getUserSelection()
        {
            System.Console.WriteLine("Please enter your selection..\n1: Rock\n2: Paper\n3: Scissors");
            int userInput = Int32.Parse(Console.ReadLine());
            //System.Console.WriteLine($"Player Selection {userInput}");
            Console. Clear();
            return userInput;
        }

        // Gets the computers selected answer
        public int getComputersSelection()
        {
            Random rnd = new Random();
            int computerGeneratedSelection = rnd.Next(1, 4);
            //System.Console.WriteLine($"Computer Selection {computerGeneratedSelection}");
            return computerGeneratedSelection;
        }

        // Compares the two inputs and creates a winner
        public string ComparePlayersInput(int userSelectedItem, int computerAnswer)
        {
            //Rock = 1
            //Paper = 2
            //Scissors = 3
            string winner = "";
            
            if(userSelectedItem == computerAnswer)
            {
                winner = "N";
            }
            if (userSelectedItem == 1 && computerAnswer == 3)
            {
                winner = "P";
            }
            if (userSelectedItem == 1 && computerAnswer == 2)
            {
                winner = "C";
            }
            if (userSelectedItem == 2 && computerAnswer == 1)
            {
                winner = "P";
            }
            if (userSelectedItem == 2 &&  computerAnswer == 3)
            {
                winner = "C";
            }
            if (userSelectedItem == 3 && computerAnswer == 1)
            {
                winner = "C";
            }
            if (userSelectedItem == 3 &&  computerAnswer == 2)
            {
                winner = "P";
            }
            return winner;       
        }

        // keep score
        public void KeepScore(string winner)
        {
            if (winner == "P")
            {
                roundResults.Add("win");
                System.Console.WriteLine("Player Wins");
            }
            if (winner == "C")
            {
                roundResults.Add("loss");
                System.Console.WriteLine("Computer Wins");
            }
            if (winner == "N")
            {
                roundResults.Add("tie");
                System.Console.WriteLine("Players Tied");
            }
        }

        public int[] CountScore()
        {
            foreach (string data in roundResults)
            {
                if(data == "win")
                {
                    score[0]+=1;
                }
                if(data == "loss")
                {
                    score[1]+=1;
                }
                if(data == "tie")
                {
                    score[2]+=1;
                }
            }
            return score;
        }

        // Prints game summary
        public void PrintRoundSummary()
        {
            Console. Clear();
            CountScore();
            wins = score[0];
            loss = score[1];
            ties = score[2];
            System.Console.WriteLine("Score Card:");
            System.Console.WriteLine($"Wins = {wins}\nLoss = {loss}\nTies = {ties}");
        }

        // Starts the round for the game
        public void PlayRound()
        {
            int userSelection = getUserSelection();
            int computerSelection = getComputersSelection();
            string winner = ComparePlayersInput(userSelection, computerSelection);
            KeepScore(winner);
        }
    }
}