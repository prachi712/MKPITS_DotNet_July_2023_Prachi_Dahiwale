using System;
using System.Diagnostics.CodeAnalysis;

namespace naturalprogram
{
    class program
    {
        public static void Main(string[] args)
        {
            int num=0 ;
            int sum = 0;
            float avg=0;
            while (num <= 10)
            {
                sum = sum + num;
                avg = sum / 10.0f;

                

                num++;
            }
            Console.WriteLine("sum of natural no are:" + sum);
            Console.WriteLine("avg of natural no are:" + avg);

            Console.ReadKey();

        }
        
        


    }
}
