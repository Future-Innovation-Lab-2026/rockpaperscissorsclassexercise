using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RpsScoreApp
{
    internal class RockPaperScissorsGame
    {
        private bool ValidateMove(string playerMove)
        {
            if ((playerMove == "R") || (playerMove == "S") || (playerMove == "P"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Play()
        {
            int rounds = 5;

            Console.WriteLine("Please Enter Player 1 Name:");
            string player1Name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Please Enter Player 2 Name:");
            string player2Name = Console.ReadLine();

            int currentRound = 1;

            ScoreTracker tracker = new ScoreTracker(player1Name, player2Name);

            while (currentRound <= rounds)
            {
                Console.WriteLine($"Round {currentRound} of {rounds} Fight!!");

                bool player1ValidMove = false;

                string player1Move = string.Empty;

                while (!player1ValidMove)
                {

                    Console.WriteLine($"{player1Name} please Enter Your Move (R) Rock, (S) Scissors, (P) Paper.");
                    player1Move = Console.ReadLine();
                    player1Move = player1Move.ToUpper();
                    player1ValidMove = ValidateMove(player1Move);

                    if (!player1ValidMove)
                    Console.WriteLine($"{player1Name}!!!!!! Please type only (R), (S) or (P)");

                }

                bool player2ValidMove = false;
                string player2Move = string.Empty;

                while (!player2ValidMove)
                {
                    Console.WriteLine($"{player2Name} please Enter Your Move (R) Rock, (S) Scissors, (P) Paper.");
                    player2Move = Console.ReadLine();

                    player2Move = player2Move.ToUpper();
                    player2ValidMove = ValidateMove(player2Move);

                    if (!player2ValidMove)
                        Console.WriteLine($"{player2Name}!!!!!! Please type only (R), (S) or (P)");

                }



                if (player1Move == player2Move)
                    {
                        //This is a tie?

                    }
                    else if ((player1Move == "R" && player2Move == "S") || (player1Move == "P" && player2Move == "R") || (player1Move == "S" && player2Move == "P"))
                    {
                        // Player 1 Wins
                        PlayerScore roundWinnerScore = tracker.UpdateScore(Player.Player1);
                        Console.WriteLine($"Well Done {roundWinnerScore.GetPlayerName()}! Your score is: {roundWinnerScore.GetPlayerScore()} ");

                    }
                    else
                    {
                        // Player 2 Wins
                        PlayerScore roundWinnerScore =  tracker.UpdateScore(Player.Player2);
                        Console.WriteLine($"Well Done {roundWinnerScore.GetPlayerName()}! Your score is: {roundWinnerScore.GetPlayerScore()} ");

                    }

                    currentRound++;
            }


            OverallResult overallWinner = tracker.GetWinner();

            GameResult result = overallWinner.GetResult();
            PlayerScore winner = overallWinner.GetWinner();

            if (result == GameResult.Win)
            {
                Console.WriteLine($"The overall winner is: {winner.GetPlayerName()} ");
            }
            else
            {
                Console.WriteLine("It is a tie");
            }
        }
    }
}
