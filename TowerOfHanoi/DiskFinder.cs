using System.Linq;

namespace TowerOfHanoi
{
    public class DiskFinder
    {
        public Tower FindDisk(Game game, string disk)
        {
            return game.Towers.Cast<Tower>()
                .FirstOrDefault(tower => tower.TopDisk() == disk);
        }
    }
}