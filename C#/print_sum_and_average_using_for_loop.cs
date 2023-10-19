using System;
namespace Program
{
    class program
    {
        public static void Main(string[]args)
        {
            int sum = 0;
            for(int counter=1;counter<=7;counter++)
            {
                sum = sum + counter;
                Console.WriteLine("natural numbers:" + counter);
            }
            Console.WriteLine("sum of numbers:" + sum);
        }
    }
}