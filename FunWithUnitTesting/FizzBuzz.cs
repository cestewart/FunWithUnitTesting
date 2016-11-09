using System;

namespace FunWithUnitTesting
{
    public class FizzBuzz : IFizzBuzz
    {
        private readonly IFunWithUnitTestingConfiguration _funWithUnitTestingConfiguration;
        private readonly IFizzBuzzMath _fizzBuzzMath;

        public FizzBuzz(IFunWithUnitTestingConfiguration funWithUnitTestingConfiguration, IFizzBuzzMath fizzBuzzMath)
        {
            _funWithUnitTestingConfiguration = funWithUnitTestingConfiguration;
            _fizzBuzzMath = fizzBuzzMath;
        }

        public void Execute()
        {
            for (var i = 1; i <= _funWithUnitTestingConfiguration.RunTimes; i++)
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
