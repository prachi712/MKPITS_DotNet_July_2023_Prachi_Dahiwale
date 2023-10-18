using System;
namespace Program
{
    class program
    {
        public static void Main(string[]args)
        {
            int num, square;
            char choice = 'y';
            do
            {
                Console.ReadLine("enter number");
                num = Convert.ToInt32(Console.ReadLine());
                square = num * num;
                Console.WriteLine("square=" + square);
                Console.WriteLine("do you want to continue press y or n");
                choice = Convert.ToChar(Console.ReadLine());

            }
            while (choice == 'y' || choice == 'Y');
            Console.ReadKey();

        }
    }
}