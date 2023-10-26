using System;
namespace Program
{
    class program
    {
        static int Calculate(params int[] num)
        {
            int i, total = 0;
            for(i=0;i<num.Length;i++)
            {
                total = total + num[i];
            }
            return total;
        }
        static void Main(string[] args)
        {
            int result = Calculate(1,2,3);
            Console.WriteLine("total" + result);
            Console.ReadKey();
        }
    }
}