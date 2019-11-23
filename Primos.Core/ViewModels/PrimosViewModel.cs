using MvvmCross.Commands;
using MvvmCross.ViewModels;
using Primos.Core.Services;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Primos.Core.ViewModels
{
    public class PrimosViewModel : MvxViewModel
    {
        private readonly IPrimosService _primosService;
        private int _n;
        private string _result;
        private MvxCommand _calculateCommand;

        public PrimosViewModel(IPrimosService primosService)
        {
            _primosService = primosService;
        }
        public int N
        {
            get =>  _n;
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
            Result = _primosService.GetPrimo(N);
        }
    }
}
