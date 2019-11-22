using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TaylorModify.Core.Services;

namespace TaylorModify.Core.ViewModels
{
    public class TaylorModifyViewModel : MvxViewModel
    
    {
        private readonly ITaylorModifyService _taylorModifyService;
        private int _x;
        private int _lim;
        private double _result;
        private MvxCommand _calculateCommand;

        public TaylorModifyViewModel(ITaylorModifyService taylorModifyService)
        {
            _taylorModifyService = taylorModifyService;
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
            Result = _taylorModifyService.GetTaylor(X, Lim);
        }
    }
}
