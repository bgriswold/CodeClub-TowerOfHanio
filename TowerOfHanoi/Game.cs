using System.Linq;

namespace TowerOfHanoi
{
    public class Game   
    {
        private readonly Towers _towers = new Towers();
        public Towers Towers
        {
            get { return _towers; }
        }
        
        public int MinMoves(int diskCount)
        {
            return MersenneNumberCalculator.Nth(diskCount);
        }

        public void Setup(int diskCount)
        {
            Towers.Clear();
            AddDisksToTowerA(diskCount);
        }

        private void AddDisksToTowerA(int diskCount)
        {
            for (int i = diskCount; i > 0; i--)
            {
                var label = new NumericToAlphaConverter().ConvertIt(i);
                Towers.Tower1.AddDisk(label);
            }
        }

        public void Play(int diskCount)
        {
            Setup(diskCount);
            if (diskCount % 2 == 0)
            {
                //odd disks cycle up
                //even disks cycle down
                //first disk first moves to B
            }
            else
            {
                // odd disks cycle down
                // even disks cycle up
                // first disk first moves to C
            }
        }

        
    }

}