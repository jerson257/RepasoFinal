using FibonacciModify.Core.Services;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FibonacciModify.Core.ViewModels
{
    public class FibonacciModifyViewModel : MvxViewModel
    {
        private readonly IFibonacciModifyService _fibonacciModifyService;
        private int _n;
        private string _result;
        private MvxCommand _calculateCommand;

        public FibonacciModifyViewModel(IFibonacciModifyService fibonacciModifyService)
        {
            _fibonacciModifyService = fibonacciModifyService;
        }
        
        public int N
        {
            get => _n;
            set => SetProperty(ref _n, value);
        }

        public string Result
        {
            get => _result;
            set => SetProperty(ref _result, value);
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

            N = 0;
            Calculate();
        }

        private void Calculate()
        {
            Result = _fibonacciModifyService.GetFibonacciModify(N);
        }
    }
}
