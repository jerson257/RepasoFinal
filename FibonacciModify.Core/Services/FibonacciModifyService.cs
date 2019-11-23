using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciModify.Core.Services
{
    public class FibonacciModifyService : IFibonacciModifyService
    {
        public string GetFibonacciModify(int n)
        {
            double a = 0, b = 1, c=2,d, s = 3;
            string fibo = String.Format("{0,10:N0}{1,10:N0}{2,10:N0}", a, b,c);
            for (int i = 4; i <= n; i++)
            {
                d = a + b + c;
                fibo += String.Format("{0,10:N0}", d);
                s += d;
                a = b;
                b = c;
                c = d;
            }
            fibo += String.Format("\nLa suma es: {0,10:N0}", s);
            return fibo;

        }
    }
}

