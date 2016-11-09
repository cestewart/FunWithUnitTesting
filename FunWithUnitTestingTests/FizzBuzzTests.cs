using System;
using System.IO;
using FunWithUnitTesting;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace FunWithUnitTestingTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private Mock<IFizzBuzzMath> _stubFizzBuzzMath;

        [SetUp]
        public void SetUp()
        {
            _stubFizzBuzzMath = new Mock<IFizzBuzzMath>();
        }

        [Test]
        public void execute_should_call_GetFizzBuzzMessage()
        {
            var mockFizzBuzz = new Mock<FizzBuzz>(_stubFizzBuzzMath.Object) { CallBase = true };
            mockFizzBuzz.Setup(i => i.GetFizzBuzzMessage(It.IsAny<int>())).Returns(It.IsAny<string>()).Verifiable();

            mockFizzBuzz.Object.Execute(10);

            mockFizzBuzz.Verify(i => i.GetFizzBuzzMessage(It.IsAny<int>()), Times.Exactly(10));
        }

        [Test]
        public void execute_should_call_GetFizzBuzzMessage_and_output_results()
        {
            using (var stringWriter = new StringWriter())
            {
                Console.SetOut(stringWriter);

                var mockFizzBuzz = new Mock<FizzBuzz>(_stubFizzBuzzMath.Object) {CallBase = true};
                mockFizzBuzz.Setup(i => i.GetFizzBuzzMessage(It.IsAny<int>())).Returns("Fun").Verifiable();

                mockFizzBuzz.Object.Execute(10);

                mockFizzBuzz.Verify(i => i.GetFizzBuzzMessage(It.IsAny<int>()), Times.Exactly(10));
                Assert.AreEqual("Fun\r\nFun\r\nFun\r\nFun\r\nFun\r\nFun\r\nFun\r\nFun\r\nFun\r\nFun\r\n", stringWriter.ToString());
            }
        }

        [Test]
        public void should_return_FizzBuzz_from_GetFizzBuzzMessage()
        {
            var mockFizzBuzzMath = new Mock<IFizzBuzzMath>();
            mockFizzBuzzMath.Setup(i => i.IsDivisibleByThree(It.IsAny<int>())).Returns(true).Verifiable();
            mockFizzBuzzMath.Setup(i => i.IsDivisibleByFive(It.IsAny<int>())).Returns(true).Verifiable();

            var mockFizzBuzz = new Mock<FizzBuzz>(mockFizzBuzzMath.Object) { CallBase = true };

            Assert.AreEqual("FizzBuzz", mockFizzBuzz.Object.GetFizzBuzzMessage(15));

            mockFizzBuzzMath.VerifyAll();
        }

        [Test]
        public void should_return_Fizz_from_GetFizzBuzzMessage()
        {
            var mockFizzBuzzMath = new Mock<IFizzBuzzMath>();
            mockFizzBuzzMath.Setup(i => i.IsDivisibleByThree(It.IsAny<int>())).Returns(true).Verifiable();
            mockFizzBuzzMath.Setup(i => i.IsDivisibleByFive(It.IsAny<int>())).Returns(false).Verifiable();

            var mockFizzBuzz = new Mock<FizzBuzz>(mockFizzBuzzMath.Object) { CallBase = true };

            Assert.AreEqual("Fizz", mockFizzBuzz.Object.GetFizzBuzzMessage(3));

            mockFizzBuzzMath.VerifyAll();
        }

        [Test]
        public void should_return_Buzz_from_GetFizzBuzzMessage()
        {
            var mockFizzBuzzMath = new Mock<IFizzBuzzMath>();
            mockFizzBuzzMath.Setup(i => i.IsDivisibleByThree(It.IsAny<int>())).Returns(false).Verifiable();
            mockFizzBuzzMath.Setup(i => i.IsDivisibleByFive(It.IsAny<int>())).Returns(true).Verifiable();

            var mockFizzBuzz = new Mock<FizzBuzz>(mockFizzBuzzMath.Object) { CallBase = true };

            Assert.AreEqual("Buzz", mockFizzBuzz.Object.GetFizzBuzzMessage(3));

            mockFizzBuzzMath.VerifyAll();
        }

        [Test]
        public void should_return_number_from_GetFizzBuzzMessage()
        {
            var mockFizzBuzzMath = new Mock<IFizzBuzzMath>();
            mockFizzBuzzMath.Setup(i => i.IsDivisibleByThree(It.IsAny<int>())).Returns(false).Verifiable();
            mockFizzBuzzMath.Setup(i => i.IsDivisibleByFive(It.IsAny<int>())).Returns(false).Verifiable();

            var mockFizzBuzz = new Mock<FizzBuzz>(mockFizzBuzzMath.Object) { CallBase = true };

            Assert.AreEqual("16", mockFizzBuzz.Object.GetFizzBuzzMessage(16));

            mockFizzBuzzMath.VerifyAll();
        }
    }
}
