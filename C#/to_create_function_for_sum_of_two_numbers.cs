using System;
using System.Diagnostics.CodeAnalysis;

namespace program
{
    class program
    {
        static int display(int num1,int num2)
        {
            int result=0;
             result = num1 + num2;
            return result;
        }
        static void Main(string[]args)
        {
            int number1, number2;
            Console.WriteLine("enter numnber1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter numnber2");
            number2 = Convert.ToInt32(Console.ReadLine());
            int res = display(number1, number2);
            Console.WriteLine("the sum of two numbers is:" +res);
        }
    }
}