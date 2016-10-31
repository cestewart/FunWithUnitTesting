namespace FunWithUnitTesting
{
    public class FizzBuzzMath : IFizzBuzzMath
    {
        public virtual bool IsDivisibleByThree(int number)
        {
            return number % 3 == 0;
        }

        public virtual bool IsDivisibleByFive(int number)
        {
            return number % 5 == 0;
        }
    }
}
