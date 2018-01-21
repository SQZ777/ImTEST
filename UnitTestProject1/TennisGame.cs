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
                if (IsDeuce())
                {
                    return Deuce();
                }
                return SameScore();
            }
            return scoreDictionary[_firstPlayerScore] + " " + scoreDictionary[_secondPlayerScore];
        }

        private string SameScore()
        {
            return scoreDictionary[_firstPlayerScore] + " All";
        }

        private static string Deuce()
        {
            return "Deuce";
        }

        private bool IsDeuce()
        {
            return _firstPlayerScore >= 3;
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