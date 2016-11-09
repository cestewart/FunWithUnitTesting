using System;
using System.Reflection;
using Ninject;

namespace FunWithUnitTesting
{
    class Program
    {
        static void Main()
        {
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var fizzBuzz =  kernel.Get<IFizzBuzz>();

            fizzBuzz.Execute(100);

            Console.WriteLine("Finished...press any key to exit.");
            Console.ReadKey();
        }
    }
}
