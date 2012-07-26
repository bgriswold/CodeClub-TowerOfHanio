using System;
using System.Collections.Generic;
using System.Linq;

namespace TowerOfHanoi
{
    public class MoveCalculator
    {
        public IEnumerable<string> GeneratePlaySequence(int diskCount)
        {
            string result = "";
            var converter = new AlphaNumericConverter();

            for (int i = 1; i <= diskCount; i++)
            {
                if (PowerOfTwoValidator.IsNot(result.Length + 1)) continue;

                var temp = result;
                result = temp + converter.NumericToAlpha(i) + temp;
            }

            var patter = result.ToArray().Select(n => Convert.ToString(n)).ToArray();
            return patter;
        }

        public Move GenerateNextMove(Game game, int diskCount, string disk)
        {
            var index = new AlphaNumericConverter().AlphaToNumeric(disk);

            var move = new Move { Disk = disk };

            if (diskCount % 2 == 0)
            {
                move.StepDirection = index % 2 == 0
                                         ? StepDirection.Back
                                         : StepDirection.Forward;
            }
            else
            {
                move.StepDirection = index % 2 == 0
                                         ? StepDirection.Forward
                                         : StepDirection.Back;
            }

            return move;
        }
    }
}