using System;
using System.Collections.Generic;

namespace TennisGameKataTests
{
    public class TennisGame
    {
        private const string FORTY_TO_FORTY = "Deuce";
        private Player player1;
        private Player player2;
        private static Dictionary<int,string> scoreEquivalency = new Dictionary<int, string>
        {
            {0, "Love"},
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" },
            {4, "Advantage" }
        };
        public TennisGame(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;

        }

        public String GetScore()
        {
            if (IsOnePlayerAdvantage()) return player1.Score == 4 ? String.Format("{0} Player One", scoreEquivalency[player1.Score]) : String.Format("{0} Player Two", scoreEquivalency[player2.Score]);

            if (player1.Score == 3 && player1.Score == player2.Score)
                return FORTY_TO_FORTY;

            return String.Format("Player One {0} - Player Two {1}", scoreEquivalency[player1.Score], scoreEquivalency[player2.Score]);

        }

        private bool IsOnePlayerAdvantage()
        {
            return player1.Score == 4 || player2.Score == 4;
        }
    }
}