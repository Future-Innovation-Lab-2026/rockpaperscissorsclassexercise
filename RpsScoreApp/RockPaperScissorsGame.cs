using System;
using System.Collections.Generic;
using System.Text;

namespace RpsScoreApp
{
    internal class RockPaperScissorsGame
    {


        public void Play()
        {
            int rounds = 5;

            Console.WriteLine("Please Enter Player 1 Name:");
            string player1 = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Please Enter Player 2 Name:");
            string player2 = Console.ReadLine();

            int currentRound = 1;

            while (currentRound <= rounds)
            {
                Console.WriteLine($"Round {currentRound} of {rounds} Fight!!");


                Console.WriteLine($"{player1} please Enter Your Move (R) Rock, (S) Scissors, (P) Paper.");
                string player1Move = Console.ReadLine();

                Console.WriteLine($"{player2} please Enter Your Move (R) Rock, (S) Scissors, (P) Paper.");
                string player2Move = Console.ReadLine();


            }
        }
    }
}
