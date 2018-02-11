using System;
using System.Collections.Generic;

namespace TennisGameKataTests
{
    public class TennisGame
    {
        private Player player1;
        private Player player2;
        private static Dictionary<int,string> scoreEquivalency = new Dictionary<int, string>
        {
            {0, "Love"},
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" }
        };
        public TennisGame(Player player1, Player player2)
        {
            this.player1 = player1;
            this.player2 = player2;

        }

        public String GetScore()
        {
            return String.Format("Player One {0} - Player Two {1}", scoreEquivalency[player1.Score], scoreEquivalency[player2.Score]);

        }
    }
}