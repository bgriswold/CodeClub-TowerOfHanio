using System;
using NUnit.Framework;
using Should;

namespace TowerOfHanoi.Tests
{
    [TestFixture]
    public class TowerTests
    {
        [Test]
        public void Add_FirstDisk_AddsOneDiskToTower()
        {
            var tower = new Tower();
            tower.AddDisk("A");
            tower.Count.ShouldEqual(1);
            tower.TopDisk().ShouldEqual("A"); 
        }

        [Test]
        public void Add_SmallerSecondDisk_AddsOneMoreDiskToTower()
        {
            var tower = new Tower();
            tower.AddDisk("B");
            tower.AddDisk("A");
            tower.Count.ShouldEqual(2);
            tower.TopDisk().ShouldEqual("A");
        }

        [Test]
        public void Add_LargerSecondDisk_ThrowsException()
        {
            var tower = new Tower();
            tower.AddDisk("A");
            try
            {
                tower.AddDisk("B");
            }
            catch (InvalidOperationException ex)
            {
            }
            
            tower.Count.ShouldEqual(1);
            tower.TopDisk().ShouldEqual("A");
        }
    }
}