namespace TowerOfHanoi
{
    /// <summary>
    /// A Mersenne number is of the form Mn = 2n - 1. Here are a few of the first Mersenne numbers:
    /// M1 = 21 - 1 = 1 => 1
    /// M2 = 22 - 1 = 3 => 11
    /// M3 = 23 - 1 = 7 => 111 
    /// M4 = 24 - 1 = 15 => 1111
    /// M5 = 25 - 1 = 31 => 11111
    /// M6 = 26 - 1 = 63 => 111111
    /// </summary>
    public static class MersenneNumberCalculator
    {
        public static int Nth(int index)
        {
            var m = 0;
            for (var i = 0; i < index; i++)
            {
                m = 1 | (m << 1);
            }
            return m;
        }
    }
}