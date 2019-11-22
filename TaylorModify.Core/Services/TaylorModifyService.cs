using System;
using System.Collections.Generic;
using System.Text;

namespace TaylorModify.Core.Services
{
    public class TaylorModifyService: ITaylorModifyService
    {
        public double GetFactorial(int x)
        {
            if (x <= 1) return 1;
            return x * GetFactorial(x - 1);
        }

        public double GetTaylor(int x, int lim)
        {            
            double result = 1;
            for (int i = 1; i <= lim; i++)
            {
                if (i % 2 == 0)
                {
                    result += Math.Pow(x, i) / GetFactorial(i);
                }
                else
                {
                    result -= Math.Pow(x, i) / GetFactorial(i);
                }                
            }
            return result;
        }
    }
}
