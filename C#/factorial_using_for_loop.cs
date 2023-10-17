using System;
using System.Reflection.Metadata;

namespace factprogram
{
    class program
    {
        public static void Main(string[]args)
        {
            int num;
            int fact = 1;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            while(num > 0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("factorial=" + fact);
            Console.ReadKey();
        }
    }
}