using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculator.Core.Services
{
    public interface ICalculatorService
    {
        decimal TipAmount(decimal subTotal, double generosity);
    }
}
