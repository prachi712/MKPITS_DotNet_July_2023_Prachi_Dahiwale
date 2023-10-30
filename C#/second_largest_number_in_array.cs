using System;
namespace Program
{
    class Program
    {
        static void Main(string[]args)
        {
            int[] arr = { 1, 5, 2, 3, 4 };
            Array.Sort(arr);
            int n = arr[arr.Length - 2];
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
