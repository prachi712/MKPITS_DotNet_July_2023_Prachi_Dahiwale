using System;
namespace Program
{
    class program
    {
        public static void Main(string[]args)
        {
            int num = 1;
            int sum = 0;
            float avg = 0;
            do
            {
                sum = sum + num;
                avg = sum / 10.0f;
                num++;
            }
            while (num <= 10);
            Console.WriteLine("sum of natural number are:" + sum);
            Console.WriteLine("sum of average are:" + avg); 
        }
    }
}