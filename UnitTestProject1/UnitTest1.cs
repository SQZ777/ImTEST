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
    }

    public class TennisGame
    {
        public string Score()
        {
            throw new System.NotImplementedException();
        }
    }
}
