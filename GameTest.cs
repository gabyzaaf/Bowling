using NFluent;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    internal class GameTest
    {
        List<Frame> frameList = new List<Frame>();

        [SetUp]
        public void Init()
        {
            this.frameList.Add(new Frame());
            this.frameList.Add(new Frame());
            this.frameList.Add(new Frame());
            this.frameList.Add(new Frame());
            this.frameList.Add(new Frame());
            this.frameList.Add(new Frame());
            this.frameList.Add(new Frame());
            this.frameList.Add(new Frame());
            this.frameList.Add(new Frame());
            this.frameList.Add(new Frame());

        }

        [Test]
        public void Should_Add_Only_With_Zero_Nominal_Case()
        {
            List<Frame> frames = new List<Frame>();
            frames.Add(new Frame());
            frames.Add(new Frame());
            frames.Add(new Frame());

            var game = new Game(frames);
            game.Launch(0);
            game.Launch(0);
            game.Launch(0);
            game.Launch(0);
            game.Launch(0);
            Check.That(game.Score()).IsEqualTo(0);
        }


        
        [Test]
        public void Should_Add_A_Strick_To_A_Game()
        {
            var game = new Game(frameList);
            game.Launch(10);
            game.Launch(5);
            game.Launch(5);
            game.Launch(10);
            game.Launch(8);
            game.Launch(2);
            game.Launch(5);
            game.Launch(3);
            game.Launch(9);
            game.Launch(1);
            game.Launch(2);
            game.Launch(2);
            game.Launch(10);
            game.Launch(10);
            game.Launch(3);
            game.Launch(5);
            Check.That(game.Score()).IsEqualTo(148);
        }
        
        [Test]
        public void Should_Add_Multiple_Frame_With_One_Strick()
        {
            List<Frame> frames = new List<Frame>();
            frames.Add(new Frame());
            frames.Add(new Frame());
            frames.Add(new Frame());
            var game = new Game(frames);
            game.Launch(10);
            game.Launch(2);
            game.Launch(4);
            Check.That(game.Score()).IsEqualTo(22);
        }

        [Test]
        public void Should_Add_Multiple_Frame_With_One_Strick_And_One_Spare()
        {
            List<Frame> frames = new List<Frame>();
            frames.Add(new Frame());
            frames.Add(new Frame());
            frames.Add(new Frame());
            
            var game = new Game(frames);
            game.Launch(10);
            game.Launch(8);
            game.Launch(2);
            game.Launch(5);
            game.Launch(2);
            Check.That(game.Score()).IsEqualTo(42);
        }

        [Test]
        public void Should_Add_Multiple_Strick()
        {
            List<Frame> frames = new List<Frame>();
            frames.Add(new Frame());
            frames.Add(new Frame());
            frames.Add(new Frame());

            var game = new Game(frames);
            game.Launch(10);
            game.Launch(10);
            game.Launch(5);
            game.Launch(2);
            Check.That(game.Score()).IsEqualTo(49);
        }


    }
}
