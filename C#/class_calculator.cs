using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_calculator_windows
{
    internal class calculator
    {

        int a = 0;
        int b = 0;
        public int Addition(int a, int b)
        {
            int result;
            result = a + b;
            return result;

        }
        public int Substraction(int a, int b)
        {
            int result;
            result = a - b;
            return result;
        }
        public int Multiplication(int a, int b)
        {
            int result;
            result = a * b;
            return result;
        }
        public int Division(int a, int b)
        {
            int result;
            result = a / b;
            return result;
        }
    }
}





    


