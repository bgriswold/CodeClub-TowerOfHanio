using System;
using NUnit.Framework;
using Should;

namespace TowerOfHanoi.Tests
{
    [TestFixture]
    public class PlayTest
    {
        //[Test]
        //public void Setup_DiskCount1_Adds1DiskToTowerA()
        //{
        //    Verify_Play(1);
        //}
        
        //private static void Verify_Play(int diskCount)
        //{
        //    var game = new Game();
        //    game.Setup(diskCount);
        //    game.Play(diskCount);
        //    game.Towers.Tower3.Count.ShouldEqual(diskCount);
        //}

        [Test]
        public void Tower_Moves()
        {
            var game = new Game();
            game.Setup(3);

            Towers t = game.Towers;
            
            MoveDisk(game, "A", t.Tower3);
            MoveDisk(game, "B", t.Tower2);
            MoveDisk(game, "A", t.Tower2);
            MoveDisk(game, "C", t.Tower3);
            MoveDisk(game, "A", t.Tower1);
            MoveDisk(game, "B", t.Tower3);
            MoveDisk(game, "A", t.Tower3);

           // PrintTowers(game);
            VerifyEnd(game, "ABC");
        }

        private void PrintTowers(Game game)
        {
            foreach (var tower in game.Towers)
            {
                Console.WriteLine(tower);
                while (tower.TopDisk() != null)
                {
                    Console.WriteLine(tower.RemoveDisk());
                }

                Console.WriteLine("");
            }
        }

        private void VerifyEnd(Game game, string expected)
        {
            game.Towers.Tower1.Count.ShouldEqual(0);
            game.Towers.Tower2.Count.ShouldEqual(0);

            var values = "";
            while (game.Towers.Tower3.TopDisk() != null)
            {
                values += game.Towers.Tower3.RemoveDisk();
            }

            values.ShouldEqual(expected);
        }
        
        private static void MoveDisk(Tower source, Tower destination)
        {
            var disk = source.RemoveDisk();
            destination.AddDisk(disk);
            Console.WriteLine("Move Disk {0} from {1} to {2}", disk, source, destination);
        }

        private static void MoveDisk(Game game, string disk, Tower destination)
        {
            foreach (var tower in game.Towers)
            {
                if (tower.TopDisk() == disk)
                {
                    tower.RemoveDisk();
                    destination.AddDisk(disk);
                    Console.WriteLine("Move Disk {0} from {1} to {2}", disk, tower, destination);
                    break;
                }
            }
        }
    }
}