using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Factorial.Core.ViewModels;

namespace Factorial.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<FactorialViewModel>();
        }
    }
}
