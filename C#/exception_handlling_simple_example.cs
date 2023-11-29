using System;
using System.Collections.Generic;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            int num;
            int n;
            Console.WriteLine("enter number 1");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            n = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            try
            {
                res = num / n;
            }
            catch
            {
                Console.WriteLine("csnnot devide by zero"); 
            }
            Console.WriteLine("res=" + res);
            Console.WriteLine("byee");
        }
    }
}
