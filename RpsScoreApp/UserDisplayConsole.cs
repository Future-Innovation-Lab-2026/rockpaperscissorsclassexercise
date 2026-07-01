using System;
using System.Collections.Generic;
using System.Text;

namespace RpsScoreApp
{
    internal class UserDisplayConsole
    {
        public void Display()
        {

           int rounds = 5;

           Console.WriteLine("Please Enter Player 1 Name:");
           string player1 = Console.ReadLine();

           Console.Clear();

           Console.WriteLine("Please Enter Player 2 Name:");
           string player2 = Console.ReadLine();

           ScoreTracker tracker = new ScoreTracker(player1,player2);

            int currentRound = 1;
            //for(int currentRound=1; currentRound <= rounds; currentRound++)
            while (currentRound <= rounds)
            {
                Console.WriteLine($"Round {currentRound} of {rounds} Fight!!");

                Console.WriteLine("Please Enter Who Won this round? (1) is for Player 1 (2) is for Player 2");

                string roundWinner = Console.ReadLine();


                if (roundWinner == "1" || roundWinner == "2")
                {
                    PlayerScore roundWinnerScore;
                    
                    if (roundWinner == "1")  
                        roundWinnerScore = tracker.UpdateScore(Player.Player1);
                    else
                        roundWinnerScore = tracker.UpdateScore(Player.Player2);

                    Console.WriteLine($"Well Done {roundWinnerScore.GetPlayerName()}! Your score is: {roundWinnerScore.GetPlayerScore()} ");

                    currentRound++;
                }
                else
                {
                    Console.WriteLine("Please Enter only (1) or (2).");
                  
                }
                
              
            }
        }
    }
}
