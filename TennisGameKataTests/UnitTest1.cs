using NFluent;
using NUnit.Framework;

namespace TennisGameKataTests
{
    
    public class UnitTest1
    {
        [Test]
        public void Should_Show_A_Score_Of_LoveToLove_When_No_Point_Gained()
        {
            var tennisGame = SetGameForTesting(0, 0);
            var expected = "Player One Love - Player Two Love";
            Check.That(tennisGame.GetScore().Equals(expected)).IsTrue();
        }

        [Test]
        public void Should_Show_A_Score_Of_1To0_When_Player1_Has_Won_One_Point()
        {
            TennisGame tennisGame = SetGameForTesting(1, 0);
            Check.That(tennisGame.GetScore().Equals("Player One Fifteen - Player Two Love")).IsTrue();
        }


        [Test]
        public void Should_Show_A_Score_Of_1To0_When_Player1_Has_Won_One()
        {
            TennisGame tennisgame = SetGameForTesting(2, 3);
            Check.That(tennisgame.GetScore().Equals("Player One Thirty - Player Two Forty")).IsTrue();
        }

        [Test]
        public void Should_Show_A_Score_Of_Deuce_If_FortyToForty()
        {
            TennisGame tennisGame = SetGameForTesting(3, 3);
            Check.That(tennisGame.GetScore().Equals("Deuce")).IsTrue();
        }

        [Test]
        public void Should_Show_The_One_With_Advantage()
        {
            TennisGame tennisGame = SetGameForTesting(4, 3);
            Check.That(tennisGame.GetScore()).IsEqualTo("Advantage Player One");
        }

        private static TennisGame SetGameForTesting(int player1sPoints, int player2sPoints)
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