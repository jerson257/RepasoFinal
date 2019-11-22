using MvvmCross.IoC;
using MvvmCross.ViewModels;
using Taylor.Core.ViewModels;

namespace Taylor.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<TaylorViewModel>();
        }
    }
}
