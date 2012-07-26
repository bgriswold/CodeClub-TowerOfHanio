using NUnit.Framework;
using Should;

namespace TowerOfHanoi.Tests
{
    [TestFixture]
    public class PowerOfTwoCheckerTests
    {
        [Test]
        public void IsPowerOfTwo_0_False()
        {
            PowerOfTwoValidator.Is(0).ShouldBeFalse();
        }

        [Test]
        public void IsPowerOfTwo_1_True()
        {
            PowerOfTwoValidator.Is(1).ShouldBeTrue();
        }

        [Test]
        public void IsPowerOfTwo_2_True()
        {
            PowerOfTwoValidator.Is(2).ShouldBeTrue();
        }

        [Test]
        public void IsPowerOfTwo_3_False()
        {
            PowerOfTwoValidator.Is(3).ShouldBeFalse();
        }

        [Test]
        public void IsPowerOfTwo_4_True()
        {
            PowerOfTwoValidator.Is(4).ShouldBeTrue();
        }
    }
}