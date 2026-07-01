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

        public OverallResult GetWinner()
        {
            PlayerScore winner=null;
            GameResult gameResult;

            if (player1Score.GetPlayerScore() == player2Score.GetPlayerScore())
            {
                gameResult = GameResult.Tie;
            }
            else
            {
                if (player1Score.GetPlayerScore() > player2Score.GetPlayerScore())
                {
                    winner = player1Score;
                    gameResult = GameResult.Win;
                }
                else
                {
                    winner = player2Score;
                    gameResult = GameResult.Win;
                }
            }

            OverallResult result = new OverallResult(gameResult, winner);
            return result;
        }
    }
}
