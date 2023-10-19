using System;
namespace Program
{
    class program
    {
        public static void Main(string[]args)
        {
            int sn = 1,en = 2;
            int num;
            Console.WriteLine("enter limit");
            num = Convert.ToInt32(Console.ReadLine());
            int res1, res2;
            for (int counter = 1; counter <= 10; counter++)
            {
                for (int counter1 = 1; counter1 <= num; counter1++)
                {
                    res1 = counter * counter1;

                    Console.Write("{0}*{1}={2}", counter, counter1, res1);
                    Console.Write("\t");
                }   
                    Console.WriteLine();

                }
            Console.ReadKey();
            }
        }
    }
