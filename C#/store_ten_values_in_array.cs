using System;
namespace Program
{
    class program
    {
        public static void Main(string[] args)
        {
            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("input 10 elements in the array");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("element-{0}={1}", i, num[i]);
            }
            Console.WriteLine("\t");
            Console.WriteLine("elements in array are:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}", num[i]);
            }
            Console.ReadKey();
        }
    }
}