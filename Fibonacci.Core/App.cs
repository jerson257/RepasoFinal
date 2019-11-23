using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Fibonacci.Core.ViewModels;

namespace Fibonacci.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<FibonacciViewModel>();
        }
    }
}
