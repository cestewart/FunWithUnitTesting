using System;

namespace FunWithUnitTesting
{
    public class FizzBuzz : IFizzBuzz
    {
        private readonly IFizzBuzzMath _fizzBuzzMath;

        public FizzBuzz(IFizzBuzzMath fizzBuzzMath)
        {
            _fizzBuzzMath = fizzBuzzMath;
        }

        public void Execute(int quantity)
        {
            Console.WriteLine($"Show Fizz Buzz {quantity} times.");
        }
    }
}
