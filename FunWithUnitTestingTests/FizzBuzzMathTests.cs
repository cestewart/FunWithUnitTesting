using FunWithUnitTesting;
using Moq;
using NUnit.Framework;

namespace FunWithUnitTestingTests
{
    [TestFixture]
    public class FizzBuzzMathTests
    {
        [Test]
        public void should_return_true_from_IsDivisibleByThree()
        {
            var mockFizzBuzzMath = new Mock<FizzBuzzMath> { CallBase = true };

            Assert.IsTrue(mockFizzBuzzMath.Object.IsDivisibleByThree(3));
            Assert.IsTrue(mockFizzBuzzMath.Object.IsDivisibleByThree(6));
        }

        [Test]
        public void should_return_false_from_IsDivisibleByThree()
        {
            var mockFizzBuzzMath = new Mock<FizzBuzzMath> { CallBase = true };

            Assert.IsFalse(mockFizzBuzzMath.Object.IsDivisibleByThree(2));
            Assert.IsFalse(mockFizzBuzzMath.Object.IsDivisibleByThree(7));
        }

        [Test]
        public void should_return_true_from_IsDivisibleByFive()
        {
            var mockFizzBuzzMath = new Mock<FizzBuzzMath> {CallBase = true};

            Assert.IsTrue(mockFizzBuzzMath.Object.IsDivisibleByFive(5));
            Assert.IsTrue(mockFizzBuzzMath.Object.IsDivisibleByFive(10));
        }

        [Test]
        public void should_return_false_from_IsDivisibleByFive()
        {
            var mockFizzBuzzMath = new Mock<FizzBuzzMath> { CallBase = true };

            Assert.IsFalse(mockFizzBuzzMath.Object.IsDivisibleByFive(4));
            Assert.IsFalse(mockFizzBuzzMath.Object.IsDivisibleByFive(9));
        }
    }
}
