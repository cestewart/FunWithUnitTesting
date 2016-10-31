using Ninject.Modules;

namespace FunWithUnitTesting
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IFizzBuzz>().To<FizzBuzz>();
            Bind<IFizzBuzzMath>().To<FizzBuzzMath>();
        }
    }
}
