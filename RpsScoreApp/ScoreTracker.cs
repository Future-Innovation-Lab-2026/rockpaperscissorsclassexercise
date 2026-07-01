using System;
using System.Collections.Generic;
using System.Text;

namespace RpsScoreApp
{
    internal class ScoreTracker
    {

        private PlayerScore player1Score;
        private PlayerScore player2Score;

      
        public  ScoreTracker(string player1Name, string player2Name)
        {
            player1Score = new PlayerScore(player1Name, 0);
            player2Score = new PlayerScore(player2Name, 0);

           

        }

        public PlayerScore UpdateScore(Player winner)
        {
            if (winner == Player.Player1)
            {
                player1Score.IncrementScore();
                return player1Score;
            }
            else if (winner == Player.Player2)
            {
                player2Score.IncrementScore();
                return player2Score;
            }

            return null;
        }

        public PlayerScore GetWinner()
        {
            if (player1Score.GetPlayerScore() == player2Score.GetPlayerScore())
                return null;

            if (player1Score.GetPlayerScore() > player2Score.GetPlayerScore())
            {
                return player1Score;
            }
            else
            {
                return player2Score;
            }

          
        }
    }
}
