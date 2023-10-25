using System;
namespace program
{
    class program
    {
        static int calculate(int num1,int num2,char op)
        {
            int res = 0;
            if (op == '+')
                res = num1 + num2;
            else if (op == '-')
                res = num1 - num2;
            else if (op == '*')
                res = num1 * num2;
            else
                Console.WriteLine("invalid");
            return res;
        }
        static void Main(string[]args)
        {
            int number1,number2;
            char oper;
            Console.WriteLine("enter number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter + - *");
            oper = Convert.ToChar(Console.ReadLine());
            int result = calculate(number1, number2, oper);
            Console.WriteLine("result" + result);
            Console.ReadKey();
        }
    }
}