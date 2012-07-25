using NUnit.Framework;
using Should;

namespace TowerOfHanoi.Tests
{
    [TestFixture]
    public class ClearTests
    {
        [Test]
        public void Tear_RemovesDisksFromTowers()
        {
            var towers = new Towers();
            towers.Clear();
            towers.Tower1.Count.ShouldEqual(0);
            towers.Tower2.Count.ShouldEqual(0);
            towers.Tower3.Count.ShouldEqual(0);
        }
    }
}