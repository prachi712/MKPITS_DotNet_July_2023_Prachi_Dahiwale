using System;
using System.Diagnostics.Metrics;

namespace Program
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("prime number:2");
            int num;
            int flag = 0;


            for (num = 3; num <= 20; num++)
            {
                flag = 0;
                int Counter = 2;
                for (Counter = 2; Counter < num; Counter++)
                {
                    if (num % 2 == 0)
                    {
                        flag = 1;
                        break;

                    }
                }
                if(flag==0)
                {
                    Console.WriteLine("prime number" + num);
                }

                    Console.ReadKey();

                }
            }
        }
    }


        
    
