using MvvmCross.IoC;
using MvvmCross.ViewModels;
using FibonacciModify.Core.ViewModels;

namespace FibonacciModify.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<FibonacciModifyViewModel>();
        }
    }
}
