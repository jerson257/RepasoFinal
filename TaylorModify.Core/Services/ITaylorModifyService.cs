using System;
using System.Collections.Generic;
using System.Text;

namespace TaylorModify.Core.Services
{
    public interface ITaylorModifyService
    {
        double GetFactorial(int x);
        double GetTaylor(int x, int lim);
    }
}
