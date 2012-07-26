using System;
using System.Linq;
using NUnit.Framework;
using Should;

namespace TowerOfHanoi.Tests
{
    [TestFixture]
    public class PlaySpikes
    {
        [Test]
        public void Play_2_Moves()
        {
            var game = new Game();
            var moves = game.Play(2);
            foreach (var move in moves)
            {
                Console.WriteLine(move);
            }
            VerifyEnd(game, "AB");
        }


        [Test]
        public void Play_3_Moves()
        {
            var game = new Game();
            var moves = game.Play(3);
            foreach (var move in moves)
            {
                Console.WriteLine(move);
            }
            VerifyEnd(game, "ABC");
        }

        [Test]
        public void Play_4_Moves()
        {
            var game = new Game();
            var moves = game.Play(4);
            foreach (var move in moves)
            {
                Console.WriteLine(move);
            }
            VerifyEnd(game, "ABCD");
        }
        [Test]
        public void Play_5_Moves()
        {
            var game = new Game();
            var moves = game.Play(5);
            foreach (var move in moves)
            {
                Console.WriteLine(move);
            }
            VerifyEnd(game, "ABCDE");
        }
        [Test]
        public void Play_6_Moves()
        {
            var game = new Game();
            var moves = game.Play(6);
            foreach (var move in moves)
            {
                Console.WriteLine(move);
            }
            VerifyEnd(game, "ABCDEF");
        }
       
        private void VerifyEnd(Game game, string expected)
        {
            game.Towers.Tower1.Count.ShouldEqual(0);
            game.Towers.Tower2.Count.ShouldEqual(0);

            var values = "";
            while (game.Towers.Tower3.TopDisk() != null)
            {
                values += game.Towers.Tower3.RemoveDisk();
            }

            values.ShouldEqual(expected);
        }
        
    }
}