using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci.Core.Services
{
    class FibonacciService: IFibonacciService
    {
        public string GetFibonacci(int n)
        {
            double a = 0,b=1, c, s=1;
            string fibo= String.Format("{0,10:N0}{1,10:N0}", a , b);
            for (int i = 3; i <= n; i++)
            {
                c = a + b;
                fibo += String.Format("{0,10:N0}", c);
                s += c;
                a = b;
                b = c;
            }
            fibo += String.Format("\nLa suma es: {0,10:N0}",s);
            return fibo;
           
        }
    }
}
