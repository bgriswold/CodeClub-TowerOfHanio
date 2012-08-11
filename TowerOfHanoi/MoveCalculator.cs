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

            var pattern = result.ToArray().Select(n => Convert.ToString(n)).ToArray();
            return pattern;
        }

        public Move GenerateNextMove(Game game, int diskCount, string disk)
        {
            var index = new AlphaNumericConverter().AlphaToNumeric(disk);

            var move = new Move { Disk = disk };
        
            var oddStackPositionStepDirection =
                StackHasOddNumberOfDisks(diskCount) // If stack has an odd disk count
                ? StepDirection.Left                // start with move to left
                : StepDirection.Right;              // else start with move to the right

            // Disks moves alternate between left and right 
            move.StepDirection =
                DiskIsInEvenStackPosition(index)                        
                ? ReverseStepDirection(oddStackPositionStepDirection)   
                : oddStackPositionStepDirection;
            
            return move;
        }

        private static StepDirection ReverseStepDirection(StepDirection startStepDirection)
        {
            return startStepDirection == StepDirection.Right
                       ? StepDirection.Left
                       : StepDirection.Right;
        }

        private static bool DiskIsInEvenStackPosition(int index)
        {
            return index % 2 == 0;
        }

        private static bool StackHasOddNumberOfDisks(int diskCount)
        {
            return diskCount % 2 != 0;
        }
    }
}