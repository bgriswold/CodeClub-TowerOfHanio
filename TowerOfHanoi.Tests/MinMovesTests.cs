using NUnit.Framework;
using Should;

namespace TowerOfHanoi.Tests
{
    [TestFixture]
    public class MinMovesTests
    {
        [Test]
        public void MinMoves_DiskCount1_1Moves()
        {
            var game = new Game();
            var result = game.PerfectScore(1);
            result.ShouldEqual(1);
        }
        
        [Test]
        public void MinMoves_DiskCount3_7Moves()
        {
            var game = new Game();
            var result = game.PerfectScore(3);
            result.ShouldEqual(7);
        }

        [Test]
        public void MinMoves_DiskCount5_31Moves()
        {
            var game = new Game();
            var result = game.PerfectScore(5);
            result.ShouldEqual(31);
        }
    }
}