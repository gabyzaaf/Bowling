using System;

namespace Bowling
{
    internal class Score
    {
        public int FirstScore { get; private set; }
        public int SecondScore { get; private set; }

        public Score(int firstScore, int secondScore)
        {
            this.FirstScore = firstScore;
            this.SecondScore = secondScore;
        }

        public bool IsStrick()
        {
            return this.FirstScore == 10;
        }

        internal bool IsSpare()
        {
            return (this.FirstScore + this.SecondScore) == 10;
        }
    }
}