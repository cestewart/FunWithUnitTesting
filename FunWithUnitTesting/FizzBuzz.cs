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
            for (var i = 1; i <= quantity; i++)
            {
                Console.WriteLine(GetFizzBuzzMessage(i));
            }
        }

        public virtual string GetFizzBuzzMessage(int number)
        {
            if (_fizzBuzzMath.IsDivisibleByThree(number) && _fizzBuzzMath.IsDivisibleByFive(number)) return "FizzBuzz";
            if (_fizzBuzzMath.IsDivisibleByThree(number)) return "Fizz";
            return _fizzBuzzMath.IsDivisibleByFive(number) ? "Buzz" : number.ToString();
        }
    }
}
