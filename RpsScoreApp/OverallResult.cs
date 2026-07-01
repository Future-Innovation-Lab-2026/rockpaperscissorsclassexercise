using System;
using System.Collections.Generic;
using System.Text;

namespace RpsScoreApp
{
    internal class OverallResult
    {
        private GameResult result;

        private PlayerScore winner;

        public OverallResult(GameResult result, PlayerScore playerScore)
        {
            this.result = result;
            this.winner = playerScore;
        }

        public GameResult GetResult()
        {
            return result;
        }

        public PlayerScore GetWinner()
        {
            return winner;
        }
    }
}
