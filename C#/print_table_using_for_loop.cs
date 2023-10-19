using System;
namespace Program
{
    class program
    {
        public static void Main(string[]args)
        {
            int res = 0;
            int multy;
            Console.WriteLine("enter number");
            multy = Convert.ToInt32(Console.ReadLine());
            for(int counter=1;counter<=10;counter++)
            {
                res = multy * counter;
                Console.WriteLine("{0}*{1}={2}", multy ,counter ,res);
                Console.Write("\t");
            }
            Console.WriteLine();
        }
    }
}