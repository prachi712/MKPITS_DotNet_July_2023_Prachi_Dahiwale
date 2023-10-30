using System;
namespace Program
{
    class Program
    {
        static void Main(string[]args)
        {
            int i, j;
            int[,] arr1 = new int[2, 2];
            Console.Write("input element");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write("element [{0}-{1}:",i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");
            Console.Write("\n matrix is:\n");
            for(i=0;i<2;i++)
            {
                Console.Write("\n");
                for(j=0;j<2;j++)
                {

                    Console.Write("{0}\t", arr1[i, j]);
                }
                Console.Write("\t");
                Console.WriteLine("transpose of matrix:");
                for(i=0;i<2;i++)
                {
                    for(j=0;j<2;j++)
                    {
                        Console.Write(arr1[j, i] + "\t");
                    }
                    Console.WriteLine("\n");
                }
                Console.ReadKey();
            }
        }
    }
}