using System;
namespace Program
{
    class program
    {
        static int returnarray()
        {


            int[] num = { 1, 2, 3 };
            return num;
        }
            static void Main(string[] args)
            {
            int[] res = returnarray();
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();

        }
    }
}
