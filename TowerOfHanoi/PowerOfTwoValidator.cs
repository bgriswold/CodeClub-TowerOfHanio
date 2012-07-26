namespace TowerOfHanoi
{
    public static class PowerOfTwoValidator
    {
        public static bool Is(int x)
        {
            return (x != 0) && ((x & (x - 1)) == 0);
        }

        public static bool IsNot(int x)
        {
            return !(Is(x));
        }
    }
}