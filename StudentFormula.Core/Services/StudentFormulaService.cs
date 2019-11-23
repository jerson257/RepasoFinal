using System;
using System.Collections.Generic;
using System.Text;

namespace StudentFormula.Core.Services
{
    public class StudentFormulaService:IStudentFormulaService
    {
        public double StudentFormulaX1(int a, int b, int c)
        {
            return (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) /( 2 * a);
        }
        public double StudentFormulaX2(int a, int b, int c)
        {
            return (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
        }
    }
}
