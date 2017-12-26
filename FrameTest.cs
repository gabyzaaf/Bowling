using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NFluent;

namespace Bowling
{
    
    public class FrameTest
    {
        Frame frame;
        [SetUp]
        public void Init()
        {
            frame = new Frame();
            frame.Launch(2);
            frame.Launch(3);
        }

        [Test]
        public void Should_Create_A_Frame_Display_The_First_And_Second_Score()
        {
         
            Check.That(frame.ObtainScoreForTheFirst()).IsEqualTo(2);
            Check.That(frame.ObtainScoreForTheSecond()).IsEqualTo(3);
        }

        [Test]
        public void Should_Display_All_The_Score_Of_The_Two_Iteration()
        {
            Check.That(frame.ObtainFrameScore()).IsEqualTo(5);
        }

        [Test]
        public void Should_Display_A_Spare()
        {
            frame = new Frame();
            frame.Launch(5);
            frame.Launch(5);
            Check.That(frame.ObtainFrameScore()).IsEqualTo(10);

        }

        [Test]
        public void Should_Display_A_Strick()
        {
            frame = new Frame();
            frame.Launch(10);
            frame.Launch(5);
            Check.That(frame.ObtainFrameScore()).IsEqualTo(10);
        }

       
    }
}
