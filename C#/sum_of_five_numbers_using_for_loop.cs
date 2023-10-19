using System;
namespace Program
{
    class program
    {
        public static void Main(string[]args)
        {
            int num;
            int sum = 0;
            for(int cntr=1;cntr<=5;cntr++)
            {
                Console.WriteLine("enter number");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine("sum of number=" + sum);
            Console.ReadKey();
        }
    }
}