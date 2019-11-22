using MvvmCross.IoC;
using MvvmCross.ViewModels;
using TaylorModify.Core.ViewModels;

namespace TaylorModify.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<TaylorModifyViewModel>();
        }
    }
}
