using System;
namespace Program
{
    class program
    {
        public static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;
            do
            {
                sum = sum + num;
                Console.WriteLine("number are" + num);
                num++;
            }
            while (num <= 7);
            Console.WriteLine("sum of numbers" + sum);
        }
    }
}