using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        TennisGame _tennisGame = new TennisGame();
        [TestMethod]
        public void Love_All()
        {
            Assert.AreEqual("Love All", _tennisGame.Score());
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            _tennisGame.SetFirstPlayerScore(1);
            Assert.AreEqual("Fifteen Love", _tennisGame.Score());
        }

        [TestMethod]
        public void Thirty_Love()
        {
        }
    }

    public class TennisGame
    {
        private int _firstPlayerScore;

        public string Score()
        {
            if (_firstPlayerScore == 1)
            {
                return "Fifteen Love";
            }
            return "Love All";
        }

        public void SetFirstPlayerScore(int i)
        {

            _firstPlayerScore = i;
        }
    }
}
