using System.Collections.Generic;

namespace UnitTestProject1
{
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

            if (IsSameScore())
            {
                if (_firstPlayerScore >= 3)
                {
                    return "Deuce";
                }
                return scoreDictionary[_firstPlayerScore] + " All";
            }
            return scoreDictionary[_firstPlayerScore] + " " + scoreDictionary[_secondPlayerScore];
        }

        private bool IsSameScore()
        {
            return _firstPlayerScore == _secondPlayerScore;
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