using MvvmCross.IoC;
using MvvmCross.ViewModels;
using StudentFormula.Core.ViewModels;

namespace StudentFormula.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<StudentFormulaViewModel>();
        }
    }
}
