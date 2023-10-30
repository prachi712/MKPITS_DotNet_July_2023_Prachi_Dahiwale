using System;
namespace Program
{
    class program
    {
        static void Main(string[]args)
        {
            int[] arr = { 1, 3, 5 };
            Array.Sort(arr);
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}