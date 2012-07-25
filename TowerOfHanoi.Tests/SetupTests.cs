using NUnit.Framework;
using Should;

namespace TowerOfHanoi.Tests
{
    [TestFixture]
    public class SetupTests
    {
        [Test]
        public void Setup_DiskCount1_Adds1DiskToTowerA()
        {
            Verify_Setup(1, 1);
        }

        [Test]
        public void Setup_DiskCount2_Adds2DiskToTowerA()
        {
            Verify_Setup(2, 2);
        }

        [Test]
        public void Setup_DiskCount3_Adds3DiskToTowerA()
        {
            Verify_Setup(3, 3);
        }

        private static void Verify_Setup(int diskCount, int expected)
        {
            var game = new Game();
            game.Setup(diskCount);
            game.Towers.Tower1.Count.ShouldEqual(expected);
        }
    }
}