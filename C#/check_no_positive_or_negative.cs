using System;
namespace PosnegProgram
{
    class positivenegative
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("enter num");
            num = Convert.ToInt32(Console.ReadLine());
            if (num>0)
            {
                Console.WriteLine("num is positive integer");
            }
            else 
            {
                Console.WriteLine("num is negative");
            }
            Console.ReadKey();
        }
    }
}