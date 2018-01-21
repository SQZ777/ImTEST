using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Love_All()
        {
            var tennisGame = new TennisGame();
            Assert.AreEqual("Love All", tennisGame.Score());
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            var tennisGame = new TennisGame();
            tennisGame.SetFirstPlayerScore(1);
            Assert.AreEqual("Fifteen Love", tennisGame.Score());
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
