using System;
namespace Programeone
{
    class program
    {
        public static void Main(string[]args)
        {
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0) goto Even;
            Console.WriteLine("odd no");
            goto End;
        Even:
            Console.WriteLine("even number");
        End:
            Console.WriteLine("bye");
            Console.ReadKey();


        }
    }
}