using System;
using System.Collections.Generic;
using System.Text;

namespace Primos.Core.Services
{
    public class PrimosService : IPrimosService
    {
        public string GetPrimo(int n)
        {
            int cont = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    cont ++;
                }                
            }
            if (cont == 2)
            {
                return "Is Primo";
            }
            else
            {
                return "Not is Primo";
            }
        }
    }
}
