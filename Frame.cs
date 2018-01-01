using System;

namespace Bowling
{
    internal class Frame
    {
        private int pins;
        private int secondScore;
        private int firstScore;
        private bool first;
        public int TotalScore { get; set; }
        public bool Second { get; private set; }

        public Frame()
        {
            this.pins = 10;
            this.first = true;
        }

        internal void Launch(int pin)
        {
            if (this.first)
            {
                this.pins = pin;
                this.firstScore = pin;
                this.first = false;
                
            }
            else if(this.firstScore != 10)
            {
                this.pins = pin;
                this.secondScore = pin;
                this.Second = true;
            }
        }

        internal bool IsStrick()
        {
            return this.firstScore == 10;
        }

        internal int ObtainFrameScore()
        {
            if (TotalScore == 0)
            {
                TotalScore = this.firstScore + this.secondScore;
            }
            return this.TotalScore;
        }

        internal int ObtainScoreForTheFirst()
        {
            return this.firstScore;
        }

        internal bool IsSpare()
        {
            return (this.firstScore + this.secondScore) == 10;
        }

        internal int ObtainScoreForTheSecond()
        {
            return this.secondScore;
        }

        public override string ToString()
        {
            return $"FirstScore --> {this.firstScore} - SecondScore {this.secondScore}";
        }
    }
}