using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System.Threading.Tasks;
using System.Windows.Input;
using Taylor.Core.Services;

namespace Taylor.Core.ViewModels
{
    public class TaylorViewModel : MvxViewModel
    {
        private readonly ITaylorService _taylorService;
        private int _x;
        private int _lim;
        private double _result;
        private MvxCommand _calculateCommand;

        public TaylorViewModel(ITaylorService taylorService)
        {
            _taylorService = taylorService;
        }
        public int X
        {
            get => _x;
            set => SetProperty(ref _x, value);
        }
        public int Lim
        {
            get => _lim;
            set => SetProperty(ref _lim, value);
        }

        public double Result
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
            Lim = 0;
            X = 0;
            Calculate();
        }

        private void Calculate()
        {
            Result = _taylorService.GetTaylor(X, Lim);
        }
    }
}
