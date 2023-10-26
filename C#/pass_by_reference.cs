using System;
using System.ComponentModel.DataAnnotations;

namespace Program
{
    class program
    {
        static void dispaly(ref int num1)
        {
            num1 = 20;
            Console.WriteLine("num inside method" + num1);
                
        }
        static void Main(string[] args)
        {
            int num = 10;
            dispaly(ref num);
            Console.WriteLine("num after passing inside main" + num);
            Console.ReadKey();
        }
    }
}