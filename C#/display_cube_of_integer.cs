using System;
using System.Diagnostics.CodeAnalysis;

namespace naturalprogram
{
    class program
    {
        public static void Main(string[] args)
        {
            int cnt = 1;
                int num;
            int res = 0;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            
            while (cnt <= num)
            {
                res = cnt * cnt * cnt;
                Console.WriteLine("cube of numbers are:" + num);
                
                Console.WriteLine("number is : {0} and cube  {1} is : {2} \n", cnt, cnt, res);
                cnt++;

                Console.ReadKey();

            }




        }
    }
}
