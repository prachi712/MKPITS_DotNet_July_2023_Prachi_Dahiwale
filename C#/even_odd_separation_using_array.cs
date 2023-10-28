using System;
namespace Program
{
    class program
    {
        static void Main(string[]args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] arr3 = new int[5];
            Console.WriteLine("enter number");
            for(int i=0;i<5;i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j = 0;int k = 0;
            for(int i=0;i<5;i++)
            {
                if (arr1[i]%2==0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
                Console.WriteLine("even number");
                for (i = 0; i < j; i++)
                {
                    Console.WriteLine("{0}", arr2[i]);
                }
                for (i = 0; i < k;i++)
                    {
                Console.WriteLine("{0}", arr3[i]);
            }
                Console.ReadKey();
            }
        }
    }
}