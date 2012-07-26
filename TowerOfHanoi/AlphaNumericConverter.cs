using System;
using System.Linq;

namespace TowerOfHanoi
{
    public class AlphaNumericConverter
    {
        public string NumericToAlpha(int numeric)
        {
            string alpha = String.Empty;

            while (numeric > 0)
            {
                int modulo = (numeric - 1) % 26;
                alpha = Convert.ToChar(65 + modulo) + alpha;
                numeric = (numeric - modulo) / 26;
            }

            return alpha;
        }

        public int AlphaToNumeric(string alpha)
        {
            return alpha
                .Select(c => c - 'A' + 1)
                .Aggregate((sum, next) => sum * 26 + next);
        }
    }
}