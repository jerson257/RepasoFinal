using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Primos.Core.ViewModels;

namespace Primos.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<PrimosViewModel>();
        }
    }
}
