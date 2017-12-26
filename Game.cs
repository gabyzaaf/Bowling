using System;
using System.Collections.Generic;
using System.Linq;

namespace Bowling
{
    internal class Game
    {

        private List<Frame> frameList;
        private int state = 0;

        public Game(List<Frame> frameList)
        {
            this.frameList = new List<Frame>(frameList);
        }

        internal void Launch(int pin)
        {
            var frame = this.frameList[state];
            frame.Launch(pin);
            if (frame.IsStrick())
            {
                state++;
            }
            else
            {
                if (frame.Second)
                {
                    state++;
                }
            }
            
            
        }

        internal int Score()
        {
            int totalScore = 0;
            for (int i = 0; i < frameList.Count; i++)
            {
                var currentFrame = frameList[i];
                if (i != 0)
                {
                    var lastFrame = frameList[i - 1];

                    if (lastFrame.IsStrick())
                    {
                        if (currentFrame.IsStrick() && i+1 < frameList.Count)
                        {
                            var next = frameList[i + 1];
                            totalScore += next.ObtainScoreForTheFirst();
                        }
                        totalScore += (currentFrame.ObtainFrameScore()*2);
                    }else if (lastFrame.IsSpare())
                    {
                        totalScore += (currentFrame.ObtainScoreForTheFirst()*2) + currentFrame.ObtainScoreForTheSecond();
                    }
                    else
                    {
                        totalScore += currentFrame.ObtainFrameScore();
                    }

                }
                else
                {
                    totalScore = currentFrame.ObtainFrameScore();
                }

                   
                
            }
            return totalScore;
        }
    }
}