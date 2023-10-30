using System;
namespace Program
{
    class program
    {
        static void Main(string[]args)
        {
            int[] arr = { 1, 2, 3 };
            int l = Array.IndexOf(arr, 5);
            Console.WriteLine("index of 5 is" + l);
            Console.ReadKey();
        }
    }
}