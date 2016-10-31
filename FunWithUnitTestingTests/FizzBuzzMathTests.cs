using FunWithUnitTesting;
using Moq;
using NUnit.Framework;

namespace FunWithUnitTestingTests
{
    [TestFixture]
    public class FizzBuzzMathTests
    {
        [Test]
        public void should_return_true_from_IsDivisibleByFive()
        {
            var mockFizzBuzzMath = new Mock<FizzBuzzMath> {CallBase = true};

            Assert.IsTrue(mockFizzBuzzMath.Object.IsDivisibleByFive(15));
        }
    }
}
