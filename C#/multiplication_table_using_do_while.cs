using System;
namespace Program
{
    class program
    {
        public static void Main(string[] args)
        {
            int sn = 1, en = 2;
            int res1, res2;
            int cnt = 1;
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadKey());

            do
            {
                res1 = sn * cnt;
                res2 = en * cnt;
                Console.WriteLine("{0}*{1}={2}", sn, cnt, res1);
                Console.WriteLine("\t");
                Console.WriteLine("{0}*{1}={2}", en, cnt, res2);
                cnt++;
                Console.WriteLine();
            }
            while (cnt <= 10);
            Console.ReadKey();
        }
        
    }
}