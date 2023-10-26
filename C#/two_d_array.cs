using System;
namespace Program
{
    class program
    {
        public static void Main(string[]args)
        {
            int[,] num = { { 1, 2 },{ 3, 4 } };
            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write(num[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}