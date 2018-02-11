namespace TennisGameKataTests
{
    public class Player
    {
        public int Score { get; private set; }

        public Player()
        {
            Score = 0;
        }
       

        public void HasWonPoint()
        {
            Score++;
        }
    }
}