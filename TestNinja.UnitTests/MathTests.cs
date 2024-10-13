
using NUnit.Framework;
using System.Collections.Generic;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        //[Ignore("Will take care later.")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));       
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a, b);
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(5, new [] {1, 3, 5})]
        public void GetOddNumbers_WhenCalledWithPositiveLimit_ReturnOddNumbersUptoLimit(int limit, int[] array)
        {
            var result = _math.GetOddNumbers(limit);
            
            Assert.That(result, Is.EquivalentTo(array));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-5)]
        public void GetOddNumbers_WhenCalledWithZeroOrNegetiveLimit_ReturnOddNumbersUptoLimit(int limit)
        {
            var result = _math.GetOddNumbers(limit);

            Assert.That(result, Is.Empty);
        }
    }
}
