using Fibonacci.Core.Services;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fibonacci.Core.ViewModels
{
    public class FibonacciViewModel:MvxViewModel
    {
        private readonly IFibonacciService _fibonacciService;
        private int _n;
        private string _result;
        private MvxCommand _calculateCommand;

        public FibonacciViewModel(IFibonacciService fibonacciService)
        {
            _fibonacciService = fibonacciService;
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
            Result = _fibonacciService.GetFibonacci(N);
        }
    }
}
