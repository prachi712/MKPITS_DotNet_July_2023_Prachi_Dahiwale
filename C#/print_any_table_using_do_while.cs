using System;
using System.Diagnostics.Metrics;

namespace Program
{
    class program
    {
        public static void Main(string[]args)
        {
            int sn;
            int res1=0;
            int cnt = 1;
            Console.WriteLine("enter number");
            sn = Convert.ToInt32(Console.ReadLine());
            do
            {
                
                res1 = sn * cnt;
                
                Console.WriteLine("{0}*{1}={2}", sn,cnt, res1);
                Console.Write("\t");
                
                cnt++;


            }
            while (cnt <= 10);
            Console.WriteLine();
        }
    }
}