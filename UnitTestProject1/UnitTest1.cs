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
            _tennisGame.SetFirstPlayerScore(2);
            Assert.AreEqual("Thirty Love", _tennisGame.Score());
        }

        [TestMethod]
        public void Forty_Love()
        {
            _tennisGame.SetFirstPlayerScore(3);
            Assert.AreEqual("Forty Love", _tennisGame.Score());
        }

        [TestMethod]
        public void Love_Fifteen()
        {
            _tennisGame.SetSecondPlayerScore(1);
            Assert.AreEqual("Love Fifteen",_tennisGame.Score());
        }

        [TestMethod]
        public void Love_Thirty()
        {
            _tennisGame.SetSecondPlayerScore(2);
            Assert.AreEqual("Love Thirty", _tennisGame.Score());
        }

        [TestMethod]
        public void Fifteen_All()
        {
            _tennisGame.SetFirstPlayerScore(1);
            _tennisGame.SetSecondPlayerScore(1);
            Assert.AreEqual("Fifteen All",_tennisGame.Score());
        }
    }
}
