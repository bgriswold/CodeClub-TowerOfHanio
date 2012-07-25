using System;
using NUnit.Framework;
using Should;

namespace TowerOfHanoi.Tests
{
    public class NumericToAlphaConverterTest
    {
        [Test]
        public void Convert_1_A()
        {
            var converter = new NumericToAlphaConverter();
            var actual = converter.ConvertIt(1);
            actual.ShouldEqual("A");
        }
    }
    
    public class MersenneNumberCalculatorTests
    {
        [Test]
        public void Nth_1_1()
        {
            Verify_Nth(1,1);
        }
        
        [Test]
        public void Nth_2_3()
        {
            Verify_Nth(2, 3);
        }

        [Test]
        public void Nth_3_7()
        {
            Verify_Nth(3, 7);
        }

        [Test]
        public void Nth_4_15()
        {
            Verify_Nth(4, 15);
        }

        [Test]
        public void Nth_5_31()
        {
            Verify_Nth(5, 31);
        }

        [Test]
        public void Nth_0_0()
        {
            Verify_Nth(0, 0);
        }

        private static void Verify_Nth(int index, int expected)
        {
            var nth = MersenneNumberCalculator.Nth(index);
            nth.ShouldEqual(expected);
        }
    }
}