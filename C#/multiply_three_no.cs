using System;
namespace Multiplyprogram
{
    class Multiplication
    {
        public static void Main()
        {
            int num1, num2, num3, multiply;
            Console.WriteLine("enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num3");
            num3 = Convert.ToInt32(Console.ReadLine());
            multiply = num1 * num2 * num3;
            Console.WriteLine("result +" + multiply);
            Console.ReadKey();

        }
    }
}