using System;
using System.Collections.Generic;
using System.Text;

namespace Taylor.Core.Services
{
    public interface ITaylorService
    {
        double GetFactorial(int x);
        double GetTaylor(int x, int lim);
    }
}
