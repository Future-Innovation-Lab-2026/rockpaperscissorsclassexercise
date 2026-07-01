using System;
using System.Collections.Generic;
using System.Text;

namespace RpsScoreApp
{
    internal class PlayerScore
    {
        private string playerName;
        private int playerScore;

        public PlayerScore(string playerName, int playerScore)
        {
            this.playerName = playerName;
            this.playerScore = playerScore;
        }

        public void IncrementScore()
        {
            playerScore++;
        }

        public string GetPlayerName()
        {
            return playerName;
        }

        public int GetPlayerScore()
        {
            return playerScore;
        }
    }
}
