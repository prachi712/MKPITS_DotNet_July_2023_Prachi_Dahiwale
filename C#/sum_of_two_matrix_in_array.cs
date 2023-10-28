using System;
using System.ComponentModel;
using System.Security.Cryptography;

namespace Program
{
    class program
    {
        public static void Main(string[] args)
        {
            int count0;
            
            int[,] a2 = new int[2, 2];
            Console.WriteLine("enter element of matrix[2,2]");
            for( count0 = 0; count0 < 2; count0++)
            {
                for(int count1 = 0; count1 < 2; count1++)
                {
                    int sum = 0;
                    a2[count0, count1] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("sum of row=" +sum);
                }
                for( count0=0;count0<2;count0++)
                {
                    int sum = 0;
                    for(int count1=0;count1<2;count1++)
                    {
                        sum = sum + a2[count1, count0];
                    }
                    Console.WriteLine("sum of coluumn=" + sum);
                }
                Console.ReadKey();
            }
        }
    }
}