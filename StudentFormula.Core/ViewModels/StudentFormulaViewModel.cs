using MvvmCross.Commands;
using MvvmCross.ViewModels;
using StudentFormula.Core.Services;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentFormula.Core.ViewModels
{
    public class StudentFormulaViewModel : MvxViewModel
    {
        private readonly IStudentFormulaService _studentFormulaService;
        private int _a;
        private int _b;
        private int _c;
        private double _x1;
        private double _x2;
        private MvxCommand _calculateCommand;

        public StudentFormulaViewModel(IStudentFormulaService studentFormulaService)
        {
            _studentFormulaService = studentFormulaService;
        }
        public int A
        {
            get => _a;
            set => SetProperty(ref _a, value);
        }
        public int B
        {
            get => _b;
            set => SetProperty(ref _b, value);
        }
        public int C
        {
            get => _c;
            set => SetProperty(ref _c, value);
        }

        public double X1
        {
            get => _x1;
            set => SetProperty(ref _x1, value);
        }
        public double X2
        {
            get => _x2;
            set => SetProperty(ref _x2, value);
        }

        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(Calculate);
                return _calculateCommand;
            }
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            A = 0;
            B = 0;
            C = 0;
            Calculate();
        }

        private void Calculate()
        {
            X1 = _studentFormulaService.StudentFormulaX1(A, B, C);
            X2 = _studentFormulaService.StudentFormulaX2(A, B, C);
        }
    }
}
