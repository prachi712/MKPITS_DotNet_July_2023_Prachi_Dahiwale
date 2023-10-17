using System;
namespace naturalprogram
{
    class program
    {
        public static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;
            while (num <= 7)
            {
                sum = sum + num;
                Console.WriteLine("natural no:" + sum);
                num++;
            }
            Console.WriteLine("sum of natural no are:" + sum);
            Console.ReadKey();
        }
    }
}
