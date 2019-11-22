using System;
using System.Collections.Generic;
using System.Text;

namespace Taylor.Core.Services
{
    public class TaylorService:ITaylorService
    {
        public double GetFactorial(int x)
        {            
            if (x <= 1) return 1;
            return x * GetFactorial(x - 1);
        }

        public double GetTaylor(int x, int lim)
        {
            double result = 1;
            for (int i = 1; i<=lim ; i++)
            {
                result += Math.Pow(x,i)/GetFactorial(i);
            }
            return result;
        }
    }
}
