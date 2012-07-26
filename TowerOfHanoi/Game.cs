using System.Collections.Generic;
using System.Linq;

namespace TowerOfHanoi
{
    public class Game
    {
        private readonly AlphaNumericConverter _alphaNumericCalc;
        private readonly DiskFinder _diskFinder;
        private readonly TowerFinder _towerFinder;

        public Game()
        {
            _alphaNumericCalc = new AlphaNumericConverter();
            _diskFinder = new DiskFinder();
            _towerFinder = new TowerFinder();
        }

        private readonly Towers _towers = new Towers();
        
        public Towers Towers
        {
            get { return _towers; }
        }
        
        public int PerfectScore(int diskCount)
        {
            return MersenneNumberCalculator.Nth(diskCount);
        }
        
        public List<string> Play(int diskCount)
        {
            Reset(diskCount);

            var strategy = new PlayStrategy().Calculate(this, diskCount);

            return ExecuteStrategy(strategy);
        }

        private List<string> ExecuteStrategy(IEnumerable<Move> strategy)
        {
            return strategy.Select(MoveDisk).ToList();
        }

        private void Reset(int diskCount)
        {
            Towers.Clear();
        
            for (int i = diskCount; i > 0; i--)
            {
                var label = _alphaNumericCalc.NumericToAlpha(i);
                Towers.Tower1.AddDisk(label);
            }
        }

        private string MoveDisk(Move move)
        {
            var sourceTower = _diskFinder.FindDisk(this, move.Disk);
            var destinationTower = _towerFinder.Find(this, sourceTower, move.StepDirection);

            sourceTower.RemoveDisk();
            destinationTower.AddDisk(move.Disk);
            return string.Format("Move Disk {0} from {1} to {2}", move.Disk, sourceTower, destinationTower);
        }
    }

    
}