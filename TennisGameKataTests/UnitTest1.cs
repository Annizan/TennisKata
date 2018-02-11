using NFluent;
using NUnit.Framework;

namespace TennisGameKataTests
{
    
    public class UnitTest1
    {
        [Test]
        public void Should_Show_A_Score_Of_LoveToLove_When_No_Point_Gained()
        {
            var tennisGame = StartGameForTesting(0, 0);
            var expected = "Player One Love - Player Two Love";
            Check.That(tennisGame.GetScore().Equals(expected)).IsTrue();
        }

        [Test]
        public void Should_Show_A_Score_Of_1To0_When_Player1_Has_Won_One_Point()
        {
            TennisGame tennisGame = StartGameForTesting(1, 0);
            Check.That(tennisGame.GetScore().Equals("Player One Fifteen - Player Two Love")).IsTrue();
        }


        [Test]
        public void Should_Show_A_Score_Of_1To0_When_Player1_Has_Won_One()
        {
            TennisGame tennisgame = StartGameForTesting(2, 3);
            Check.That(tennisgame.GetScore().Equals("Player One Thirty - Player Two Forty")).IsTrue();
        }

        private static TennisGame StartGameForTesting(int player1sPoints, int player2sPoints)
        {
            Player player1 = new Player();
            Player player2 = new Player();
            TennisGame tennisgame = new TennisGame(player1, player2);
            for (int i = 0; i<player1sPoints; i++)
                player1.HasWonPoint();
            for (int i = 0; i < player2sPoints; i++)
                player2.HasWonPoint();
            return tennisgame;
        }
    }
}