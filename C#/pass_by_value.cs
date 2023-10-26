using System;
namespace Program
{
    class program
    {
        static void display(int num)
        {
             num = 20;
            Console.WriteLine("num inside method" + num);
        }
        static void Main(string[]args)
        {
            int num = 10;
            display(num);
            Console.WriteLine("num after passing value" + num);
            Console.ReadKey();
        }
    }
}
