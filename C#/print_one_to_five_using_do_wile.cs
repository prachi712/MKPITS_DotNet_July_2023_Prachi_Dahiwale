using System;
namespace printprogram
{
    class program
    {
        public static void Main(string[] args)
        {
            int num = 1;
            do
            {
                Console.WriteLine("num={0}", num);
                num++;
            }
            while (num <= 5);
        }
    }
}