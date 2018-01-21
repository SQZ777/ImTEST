using System.Collections.Generic;
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
    }

    public class TennisGame
    {
        private int _firstPlayerScore;
        private int _secondPlayerScore;
        Dictionary<int, string> scoreDictionary = new Dictionary<int, string>
        {
            {0, "Love" },
            {1, "Fifteen" },
            {2, "Thirty" },
            {3, "Forty" }
        };
        public string Score()
        {
            
            if (_firstPlayerScore > 0 || _secondPlayerScore > 0)
            {
                return scoreDictionary[_firstPlayerScore] +" " + scoreDictionary[_secondPlayerScore];
            }



            return "Love All";
        }

        public void SetFirstPlayerScore(int i)
        {

            _firstPlayerScore = i;
        }

        public void SetSecondPlayerScore(int i)
        {
            _secondPlayerScore = i;
        }
    }
}
