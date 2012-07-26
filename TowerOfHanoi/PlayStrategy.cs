using System.Collections.Generic;
using System.Linq;

namespace TowerOfHanoi
{
    public class PlayStrategy
    {
        public List<Move> Calculate(Game game, int diskCount)
        {
            var calc = new MoveCalculator();

            return calc
                .GeneratePlaySequence(diskCount)
                .Select(disk => calc.GenerateNextMove(game, diskCount, disk))
                .ToList();
        }
    }
}